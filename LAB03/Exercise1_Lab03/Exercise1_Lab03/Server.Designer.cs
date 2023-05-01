namespace Exercise1_Lab03
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
            lb_ipadd = new Label();
            txt_show_mes = new RichTextBox();
            txt_send = new TextBox();
            txt_ip_add = new TextBox();
            btn_send = new Button();
            btn_connect = new Button();
            SuspendLayout();
            // 
            // lb_ipadd
            // 
            lb_ipadd.AutoSize = true;
            lb_ipadd.Location = new Point(26, 53);
            lb_ipadd.Name = "lb_ipadd";
            lb_ipadd.Size = new Size(98, 25);
            lb_ipadd.TabIndex = 11;
            lb_ipadd.Text = "IP address:";
            // 
            // txt_show_mes
            // 
            txt_show_mes.Location = new Point(26, 101);
            txt_show_mes.Name = "txt_show_mes";
            txt_show_mes.ReadOnly = true;
            txt_show_mes.Size = new Size(748, 230);
            txt_show_mes.TabIndex = 10;
            txt_show_mes.Text = "";
            // 
            // txt_send
            // 
            txt_send.Location = new Point(26, 375);
            txt_send.Name = "txt_send";
            txt_send.Size = new Size(622, 31);
            txt_send.TabIndex = 9;
            // 
            // txt_ip_add
            // 
            txt_ip_add.Location = new Point(128, 47);
            txt_ip_add.Name = "txt_ip_add";
            txt_ip_add.Size = new Size(342, 31);
            txt_ip_add.TabIndex = 8;
            // 
            // btn_send
            // 
            btn_send.Location = new Point(662, 372);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(112, 34);
            btn_send.TabIndex = 7;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // btn_connect
            // 
            btn_connect.Location = new Point(585, 44);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(112, 34);
            btn_connect.TabIndex = 6;
            btn_connect.Text = "Connect";
            btn_connect.UseVisualStyleBackColor = true;
            btn_connect.Click += btn_connect_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_ipadd);
            Controls.Add(txt_show_mes);
            Controls.Add(txt_send);
            Controls.Add(txt_ip_add);
            Controls.Add(btn_send);
            Controls.Add(btn_connect);
            Name = "Server";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_ipadd;
        private RichTextBox txt_show_mes;
        private TextBox txt_send;
        private TextBox txt_ip_add;
        private Button btn_send;
        private Button btn_connect;
    }
}