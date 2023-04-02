namespace TCP_server
{
    partial class Server
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
            this.btnListen = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.AutoSize = true;
            this.btnListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListen.Location = new System.Drawing.Point(582, 7);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(169, 47);
            this.btnListen.TabIndex = 0;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // txtChat
            // 
            this.txtChat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChat.Location = new System.Drawing.Point(12, 67);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtChat.Size = new System.Drawing.Size(776, 371);
            this.txtChat.TabIndex = 2;
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(268, 12);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(190, 39);
            this.txtPort.TabIndex = 3;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPort.Location = new System.Drawing.Point(168, 14);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(76, 37);
            this.lbPort.TabIndex = 4;
            this.lbPort.Text = "Port";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.btnListen);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lbPort;
    }
}

