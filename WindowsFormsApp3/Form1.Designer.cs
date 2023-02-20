
namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiRichTextBox2 = new Sunny.UI.UIRichTextBox();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.uiRichTextBox1 = new Sunny.UI.UIRichTextBox();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.uiRichTextBox3 = new Sunny.UI.UIRichTextBox();
            this.uiLedBulb1 = new Sunny.UI.UILedBulb();
            this.uiLedBulb2 = new Sunny.UI.UILedBulb();
            this.uiLedBulb3 = new Sunny.UI.UILedBulb();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.uiGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "127.0.0.1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "8868";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.Location = new System.Drawing.Point(12, 121);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(790, 29);
            this.uiLine1.TabIndex = 5;
            this.uiLine1.Text = "收发区";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiRichTextBox2);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(33, 158);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(287, 463);
            this.uiGroupBox1.TabIndex = 6;
            this.uiGroupBox1.Text = "接收";
            // 
            // uiRichTextBox2
            // 
            this.uiRichTextBox2.AutoScroll = true;
            this.uiRichTextBox2.AutoWordSelection = true;
            this.uiRichTextBox2.FillColor = System.Drawing.Color.White;
            this.uiRichTextBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRichTextBox2.Location = new System.Drawing.Point(10, 37);
            this.uiRichTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRichTextBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRichTextBox2.Name = "uiRichTextBox2";
            this.uiRichTextBox2.Padding = new System.Windows.Forms.Padding(2);
            this.uiRichTextBox2.Size = new System.Drawing.Size(273, 397);
            this.uiRichTextBox2.TabIndex = 1;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.button2);
            this.uiGroupBox2.Controls.Add(this.uiRichTextBox1);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(353, 158);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(442, 235);
            this.uiGroupBox2.TabIndex = 7;
            this.uiGroupBox2.Text = "发送";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // uiRichTextBox1
            // 
            this.uiRichTextBox1.AutoScroll = true;
            this.uiRichTextBox1.AutoWordSelection = true;
            this.uiRichTextBox1.FillColor = System.Drawing.Color.White;
            this.uiRichTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRichTextBox1.Location = new System.Drawing.Point(10, 37);
            this.uiRichTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRichTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRichTextBox1.Name = "uiRichTextBox1";
            this.uiRichTextBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiRichTextBox1.Size = new System.Drawing.Size(417, 143);
            this.uiRichTextBox1.TabIndex = 1;
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.uiRichTextBox3);
            this.uiGroupBox3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox3.Location = new System.Drawing.Point(353, 403);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.Size = new System.Drawing.Size(442, 218);
            this.uiGroupBox3.TabIndex = 8;
            this.uiGroupBox3.Text = "异常显示";
            // 
            // uiRichTextBox3
            // 
            this.uiRichTextBox3.AutoScroll = true;
            this.uiRichTextBox3.AutoWordSelection = true;
            this.uiRichTextBox3.FillColor = System.Drawing.Color.White;
            this.uiRichTextBox3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiRichTextBox3.Location = new System.Drawing.Point(10, 47);
            this.uiRichTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRichTextBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRichTextBox3.Name = "uiRichTextBox3";
            this.uiRichTextBox3.Padding = new System.Windows.Forms.Padding(2);
            this.uiRichTextBox3.Size = new System.Drawing.Size(417, 154);
            this.uiRichTextBox3.TabIndex = 1;
            // 
            // uiLedBulb1
            // 
            this.uiLedBulb1.Location = new System.Drawing.Point(728, 23);
            this.uiLedBulb1.Name = "uiLedBulb1";
            this.uiLedBulb1.Size = new System.Drawing.Size(40, 22);
            this.uiLedBulb1.TabIndex = 9;
            this.uiLedBulb1.Text = "uiLedBulb1";
            // 
            // uiLedBulb2
            // 
            this.uiLedBulb2.Location = new System.Drawing.Point(688, 23);
            this.uiLedBulb2.Name = "uiLedBulb2";
            this.uiLedBulb2.Size = new System.Drawing.Size(40, 22);
            this.uiLedBulb2.TabIndex = 10;
            this.uiLedBulb2.Text = "uiLedBulb2";
            // 
            // uiLedBulb3
            // 
            this.uiLedBulb3.Location = new System.Drawing.Point(768, 23);
            this.uiLedBulb3.Name = "uiLedBulb3";
            this.uiLedBulb3.Size = new System.Drawing.Size(40, 22);
            this.uiLedBulb3.TabIndex = 11;
            this.uiLedBulb3.Text = "uiLedBulb3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(486, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(486, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "test";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 635);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.uiLedBulb3);
            this.Controls.Add(this.uiLedBulb1);
            this.Controls.Add(this.uiLedBulb2);
            this.Controls.Add(this.uiGroupBox3);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIRichTextBox uiRichTextBox2;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private System.Windows.Forms.Button button2;
        private Sunny.UI.UIRichTextBox uiRichTextBox1;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Sunny.UI.UIRichTextBox uiRichTextBox3;
        private Sunny.UI.UILedBulb uiLedBulb1;
        private Sunny.UI.UILedBulb uiLedBulb2;
        private Sunny.UI.UILedBulb uiLedBulb3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

