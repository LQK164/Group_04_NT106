namespace TCP_server
{
    partial class test_client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lbIP = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = true;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(668, 439);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(120, 47);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSend_Enter);
            // 
            // txtSend
            // 
            this.txtSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSend.Location = new System.Drawing.Point(12, 441);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(650, 44);
            this.txtSend.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(547, 30);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(176, 90);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtChat
            // 
            this.txtChat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChat.Location = new System.Drawing.Point(12, 142);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtChat.Size = new System.Drawing.Size(776, 291);
            this.txtChat.TabIndex = 3;
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(154, 81);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(300, 39);
            this.txtPort.TabIndex = 4;
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(154, 30);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(300, 39);
            this.txtIP.TabIndex = 5;
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIP.Location = new System.Drawing.Point(70, 30);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(55, 37);
            this.lbIP.TabIndex = 6;
            this.lbIP.Text = "IP:";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPort.Location = new System.Drawing.Point(40, 81);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(85, 37);
            this.lbPort.TabIndex = 7;
            this.lbPort.Text = "Port:";
            // 
            // test_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.lbIP);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.btnSend);
            this.Name = "test_client";
            this.Text = "test_client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Label lbPort;
    }
}