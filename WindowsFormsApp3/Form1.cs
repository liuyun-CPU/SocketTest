using Newtonsoft.Json;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            form1 = this;
            comboBox1.Items.AddRange(commandlist);
        }
        string[] commandlist = {"write","color","btn","text" };
        private static byte[] result = new byte[1024];      //创建字节数组
        private int myPort = 8885;                   //端口
        private string myIP = "127.0.0.1";          //ip
        static Socket serverSocket;
        public static Form1 form1;
        List<Socket> ClientProxSocketList = new List<Socket>();
        Dictionary<int, Socket> SocketID = new Dictionary<int, Socket>();
        Socket proxSocket;
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myIP = textBox1.Text;
                myPort = int.Parse(textBox2.Text);
                //服务器IP地址
                IPAddress ip = IPAddress.Parse(myIP);    //构造IP
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);     //指定套接字类型：TCP模式
                                                                                                                //AddressFamily:网络类型  SocketType：套接字类型 ProtocolType:使用的网络协议
                serverSocket.Bind(new IPEndPoint(ip, myPort));  //绑定IP地址：端口
                serverSocket.Listen(10);                        //设定最多10个排队链接请求
                uiRichTextBox2.Text += ("启动监听{0}成功!", serverSocket.LocalEndPoint.ToString());
                //通过Client_Socket发送数据
                Thread myThread = new Thread(ListenClientConnect);  //创建一个新的线程，并用于监听客户端链接
                myThread.Start();
            }
            catch (Exception ex)
            {
                serverSocket.Shutdown(SocketShutdown.Both);
                serverSocket.Close();
            }
        }

        int EachID = 0;
        private static void ListenClientConnect()
        {
            try
            {
                while (true)
                {
                    Socket clientSocket = serverSocket.Accept();    //同意链接
                    form1.ClientProxSocketList.Add(clientSocket);
                    form1.EachID++;
                    form1.SendData.ID = form1.EachID;
                    form1.SendData.Command = "HandShake";
                    form1.SendData.Msg = "ID";
                    string hello = form1.MsgCode(form1.SendData);
                    clientSocket.Send(Encoding.ASCII.GetBytes(hello));     //字符串转换为字节数组，并发送
                    Thread receiverThread = new Thread(new ParameterizedThreadStart(ReceiveMessage));
                    receiverThread.Start(clientSocket);
                }
            }
            catch(Exception ex)
            {
                form1.SetText(form1.uiRichTextBox3,ex.ToString());
            }
        }

        private static void ReceiveMessage(object clientSocket)
        {
            Socket myClientSocket = (Socket)clientSocket;
            string t = "";
            while (true)
            {
                try
                {
                    //通过clientSocket接收数据
                    int receiveNumber = myClientSocket.Receive(result);     //接收缓冲数组，并读取数组内容
                    t = $"接收客户端{myClientSocket.RemoteEndPoint.ToString()}消息{Encoding.ASCII.GetString(result, 0, receiveNumber)}.";
                    form1.SetText(form1.uiRichTextBox2, t);
                    //form1.proxSocket = serverSocket.Accept();
                    //form1.dicSocket.Add(form1.proxSocket.RemoteEndPoint.ToString(), form1.proxSocket);
                    //form1.ClientProxSocketList.Add(form1.proxSocket);

                }
                catch (Exception ex)
                {
                    t = (ex.Message);
                    form1.SetText(form1.uiRichTextBox3, t);
                    myClientSocket.Shutdown(SocketShutdown.Both);
                    myClientSocket.Close();
                    break;
                }
            }
        }

        public void SetText(UIRichTextBox RichTextBox, string str)
        {
            if (RichTextBox.InvokeRequired)
            {
                Action<UIRichTextBox, string> StatusUI = new Action<UIRichTextBox, string>(SetText);
                this.Invoke(StatusUI, new object[] { RichTextBox, str });
            }
            else
            {
                RichTextBox.Text += str + Environment.NewLine;
            }
        }

        //Thread tSend = new Thread(SendAll);
        private void SendAll(object msg)
        {
            foreach (var item in ClientProxSocketList)
                SendMessage((string)msg, item);
        }
        private void SendMessage(string msg, Socket socket)
        {
            byte[] buffer = Encoding.Default.GetBytes(msg);
            socket.Send(buffer);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            TcpResponseModel tcpResponseMode = new TcpResponseModel();
            tcpResponseMode.Command = comboBox1.SelectedItem.ToString();
            tcpResponseMode.ID = (int)numericUpDown1.Value;
            tcpResponseMode.Msg = textBox4.Text;
            string t = MsgCode(tcpResponseMode);
            Thread tSend = new Thread(SendAll);
            tSend.Start(t);
        }
        
        public TcpResponseModel SendData = new TcpResponseModel();
        public TcpResponseModel RecData = new TcpResponseModel();
        private void MsgDecode(string Msg)
        {
            Msg=Msg.Replace("{","[{");
            Msg=Msg.Replace("}", "}]");
            List<TcpResponseModel> spmeasJncds = Newtonsoft.Json.JsonConvert.DeserializeObject<List<TcpResponseModel>>(Msg);
            RecData = spmeasJncds[0];
            uiRichTextBox3.Text = $"ID:{RecData.ID},cmd:{RecData.Command},msg:{RecData.Msg}" + Environment.NewLine;
        }

        private string MsgCode(TcpResponseModel data)
        {
            string msg = "";
            msg = JsonConvert.SerializeObject(data);
            return msg;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TcpResponseModel tcpResponseMode = new TcpResponseModel();
            tcpResponseMode.Command = "write";
            tcpResponseMode.ID = 0;
            tcpResponseMode.Msg = "red";
            string t=MsgCode(tcpResponseMode);
            uiRichTextBox3.Text = t+Environment.NewLine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string temp= "{\"ID\":0,\"Msg\":\"red\",\"Command\":\"write\"}";
            MsgDecode(temp);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Thread tSend = new Thread(SendAll);
            tSend.Start(uiRichTextBox1.Text);
        }
    }

    public class TcpResponseModel
    {
        /// </summary>
        public int ID { get; set; }
        public string Msg { get; set; }
        public string Command { get; set; }
        //public List<ResultModel> Content;
        //public int Result;
    }
}
