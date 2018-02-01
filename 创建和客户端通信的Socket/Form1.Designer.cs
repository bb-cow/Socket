namespace 创建和客户端通信的Socket
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnReadyListen = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnChoice = new System.Windows.Forms.Button();
            this.btnSendWJ = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnShake = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "192.168.1.107";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(185, 78);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(38, 21);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "139";
            // 
            // btnReadyListen
            // 
            this.btnReadyListen.Location = new System.Drawing.Point(247, 78);
            this.btnReadyListen.Name = "btnReadyListen";
            this.btnReadyListen.Size = new System.Drawing.Size(75, 23);
            this.btnReadyListen.TabIndex = 3;
            this.btnReadyListen.Text = "开始监听";
            this.btnReadyListen.UseVisualStyleBackColor = true;
            this.btnReadyListen.Click += new System.EventHandler(this.btnReadyListen_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(347, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(56, 130);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(524, 163);
            this.txtLog.TabIndex = 5;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(56, 335);
            this.txtServer.Multiline = true;
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(524, 163);
            this.txtServer.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(56, 541);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(335, 21);
            this.textBox5.TabIndex = 7;
            // 
            // btnChoice
            // 
            this.btnChoice.Location = new System.Drawing.Point(423, 539);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(48, 23);
            this.btnChoice.TabIndex = 8;
            this.btnChoice.Text = "选择";
            this.btnChoice.UseVisualStyleBackColor = true;
            // 
            // btnSendWJ
            // 
            this.btnSendWJ.Location = new System.Drawing.Point(493, 539);
            this.btnSendWJ.Name = "btnSendWJ";
            this.btnSendWJ.Size = new System.Drawing.Size(87, 23);
            this.btnSendWJ.TabIndex = 9;
            this.btnSendWJ.Text = "发送文件";
            this.btnSendWJ.UseVisualStyleBackColor = true;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(347, 583);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(76, 23);
            this.btnSendMessage.TabIndex = 10;
            this.btnSendMessage.Text = "发送消息";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            // 
            // btnShake
            // 
            this.btnShake.Location = new System.Drawing.Point(455, 583);
            this.btnShake.Name = "btnShake";
            this.btnShake.Size = new System.Drawing.Size(87, 23);
            this.btnShake.TabIndex = 11;
            this.btnShake.Text = "震动";
            this.btnShake.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 636);
            this.Controls.Add(this.btnShake);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.btnSendWJ);
            this.Controls.Add(this.btnChoice);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnReadyListen);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnReadyListen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnChoice;
        private System.Windows.Forms.Button btnSendWJ;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Button btnShake;
    }
}

