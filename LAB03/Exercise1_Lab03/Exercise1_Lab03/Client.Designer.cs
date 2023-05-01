namespace Exercise1_Lab03
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
            btn_connect = new Button();
            btn_send = new Button();
            txt_ip_add = new TextBox();
            txt_send = new TextBox();
            txt_show_mes = new RichTextBox();
            lb_ipadd = new Label();
            SuspendLayout();
            // 
            // btn_connect
            // 
            btn_connect.Location = new Point(583, 36);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(112, 34);
            btn_connect.TabIndex = 0;
            btn_connect.Text = "Connect";
            btn_connect.UseVisualStyleBackColor = true;
            btn_connect.Click += btn_connect_Click;
            // 
            // btn_send
            // 
            btn_send.Location = new Point(660, 364);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(112, 34);
            btn_send.TabIndex = 1;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // txt_ip_add
            // 
            txt_ip_add.Location = new Point(126, 39);
            txt_ip_add.Name = "txt_ip_add";
            txt_ip_add.Size = new Size(342, 31);
            txt_ip_add.TabIndex = 2;
            // 
            // txt_send
            // 
            txt_send.Location = new Point(24, 367);
            txt_send.Name = "txt_send";
            txt_send.Size = new Size(622, 31);
            txt_send.TabIndex = 3;
            // 
            // txt_show_mes
            // 
            txt_show_mes.Location = new Point(24, 93);
            txt_show_mes.Name = "txt_show_mes";
            txt_show_mes.ReadOnly = true;
            txt_show_mes.Size = new Size(748, 230);
            txt_show_mes.TabIndex = 4;
            txt_show_mes.Text = "";
            // 
            // lb_ipadd
            // 
            lb_ipadd.AutoSize = true;
            lb_ipadd.Location = new Point(24, 45);
            lb_ipadd.Name = "lb_ipadd";
            lb_ipadd.Size = new Size(98, 25);
            lb_ipadd.TabIndex = 5;
            lb_ipadd.Text = "IP address:";
            // 
            // Client
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
            Name = "Client";
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_connect;
        private Button btn_send;
        private TextBox txt_ip_add;
        private TextBox txt_send;
        private RichTextBox txt_show_mes;
        private Label lb_ipadd;
    }
}