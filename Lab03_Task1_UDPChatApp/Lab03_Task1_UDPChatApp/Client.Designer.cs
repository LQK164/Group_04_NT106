namespace Lab03_Task1_UDPChatApp
{
    partial class Client
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
            lb_Client = new Label();
            lb_IP_Address = new Label();
            txt_IP = new TextBox();
            txt_show_message = new TextBox();
            btn_Connect = new Button();
            txt_Send = new TextBox();
            btn_Send = new Button();
            SuspendLayout();
            // 
            // lb_Client
            // 
            lb_Client.AutoSize = true;
            lb_Client.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Client.Location = new Point(378, 9);
            lb_Client.Name = "lb_Client";
            lb_Client.Size = new Size(94, 41);
            lb_Client.TabIndex = 0;
            lb_Client.Text = "Client";
            // 
            // lb_IP_Address
            // 
            lb_IP_Address.AutoSize = true;
            lb_IP_Address.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lb_IP_Address.Location = new Point(23, 87);
            lb_IP_Address.Name = "lb_IP_Address";
            lb_IP_Address.Size = new Size(153, 38);
            lb_IP_Address.TabIndex = 1;
            lb_IP_Address.Text = "IP Address:";
            // 
            // txt_IP
            // 
            txt_IP.Location = new Point(207, 94);
            txt_IP.Name = "txt_IP";
            txt_IP.Size = new Size(265, 31);
            txt_IP.TabIndex = 2;
            // 
            // txt_show_message
            // 
            txt_show_message.Location = new Point(12, 147);
            txt_show_message.Multiline = true;
            txt_show_message.Name = "txt_show_message";
            txt_show_message.Size = new Size(776, 202);
            txt_show_message.TabIndex = 3;
            // 
            // btn_Connect
            // 
            btn_Connect.Location = new Point(588, 60);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(169, 65);
            btn_Connect.TabIndex = 4;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // txt_Send
            // 
            txt_Send.Location = new Point(23, 371);
            txt_Send.Multiline = true;
            txt_Send.Name = "txt_Send";
            txt_Send.Size = new Size(571, 64);
            txt_Send.TabIndex = 5;
            // 
            // btn_Send
            // 
            btn_Send.Location = new Point(610, 371);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(178, 67);
            btn_Send.TabIndex = 6;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // Client
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
            Controls.Add(lb_Client);
            Name = "Client";
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Client;
        private Label lb_IP_Address;
        private TextBox txt_IP;
        private TextBox txt_show_message;
        private Button btn_Connect;
        private TextBox txt_Send;
        private Button btn_Send;
    }
}