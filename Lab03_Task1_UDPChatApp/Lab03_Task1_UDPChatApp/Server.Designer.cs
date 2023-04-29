namespace Lab03_Task1_UDPChatApp
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
            btn_Send = new Button();
            txt_Send = new TextBox();
            btn_Connect = new Button();
            txt_show_message = new TextBox();
            txt_IP = new TextBox();
            lb_IP_Address = new Label();
            lb_Server = new Label();
            SuspendLayout();
            // 
            // btn_Send
            // 
            btn_Send.Location = new Point(610, 373);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(178, 67);
            btn_Send.TabIndex = 13;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // txt_Send
            // 
            txt_Send.Location = new Point(23, 373);
            txt_Send.Multiline = true;
            txt_Send.Name = "txt_Send";
            txt_Send.Size = new Size(571, 64);
            txt_Send.TabIndex = 12;
            // 
            // btn_Connect
            // 
            btn_Connect.Location = new Point(588, 62);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(169, 65);
            btn_Connect.TabIndex = 11;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // txt_show_message
            // 
            txt_show_message.Location = new Point(12, 149);
            txt_show_message.Multiline = true;
            txt_show_message.Name = "txt_show_message";
            txt_show_message.Size = new Size(776, 202);
            txt_show_message.TabIndex = 10;
            // 
            // txt_IP
            // 
            txt_IP.Location = new Point(207, 96);
            txt_IP.Name = "txt_IP";
            txt_IP.Size = new Size(265, 31);
            txt_IP.TabIndex = 9;
            // 
            // lb_IP_Address
            // 
            lb_IP_Address.AutoSize = true;
            lb_IP_Address.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lb_IP_Address.Location = new Point(23, 89);
            lb_IP_Address.Name = "lb_IP_Address";
            lb_IP_Address.Size = new Size(153, 38);
            lb_IP_Address.TabIndex = 8;
            lb_IP_Address.Text = "IP Address:";
            // 
            // lb_Server
            // 
            lb_Server.AutoSize = true;
            lb_Server.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Server.Location = new Point(378, 11);
            lb_Server.Name = "lb_Server";
            lb_Server.Size = new Size(100, 41);
            lb_Server.TabIndex = 7;
            lb_Server.Text = "Server";
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Send);
            Controls.Add(txt_Send);
            Controls.Add(btn_Connect);
            Controls.Add(txt_show_message);
            Controls.Add(txt_IP);
            Controls.Add(lb_IP_Address);
            Controls.Add(lb_Server);
            Name = "Server";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Send;
        private TextBox txt_Send;
        private Button btn_Connect;
        private TextBox txt_show_message;
        private TextBox txt_IP;
        private Label lb_IP_Address;
        private Label lb_Server;
    }
}