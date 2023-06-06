namespace Bai4
{
    partial class Bai4
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
            this.lb_Tai_Khoan = new System.Windows.Forms.Label();
            this.lb_Mat_Khau = new System.Windows.Forms.Label();
            this.txt_Tai_Khoan = new System.Windows.Forms.TextBox();
            this.txt_Mat_Khau = new System.Windows.Forms.TextBox();
            this.txt_Port_IMAP = new System.Windows.Forms.TextBox();
            this.txt_IMAP = new System.Windows.Forms.TextBox();
            this.lb_Port_IMAP = new System.Windows.Forms.Label();
            this.lb_IMAP = new System.Windows.Forms.Label();
            this.txt_Port_SMTP = new System.Windows.Forms.TextBox();
            this.txt_SMTP = new System.Windows.Forms.TextBox();
            this.lb_Port_SMTP = new System.Windows.Forms.Label();
            this.lb_SMTP = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lv_mails = new System.Windows.Forms.ListView();
            this.No_of_mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Source = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lb_Tai_Khoan
            // 
            this.lb_Tai_Khoan.AutoSize = true;
            this.lb_Tai_Khoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tai_Khoan.Location = new System.Drawing.Point(12, 20);
            this.lb_Tai_Khoan.Name = "lb_Tai_Khoan";
            this.lb_Tai_Khoan.Size = new System.Drawing.Size(164, 37);
            this.lb_Tai_Khoan.TabIndex = 0;
            this.lb_Tai_Khoan.Text = "Tài Khoản";
            // 
            // lb_Mat_Khau
            // 
            this.lb_Mat_Khau.AutoSize = true;
            this.lb_Mat_Khau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mat_Khau.Location = new System.Drawing.Point(17, 73);
            this.lb_Mat_Khau.Name = "lb_Mat_Khau";
            this.lb_Mat_Khau.Size = new System.Drawing.Size(149, 37);
            this.lb_Mat_Khau.TabIndex = 1;
            this.lb_Mat_Khau.Text = "Mật khẩu";
            // 
            // txt_Tai_Khoan
            // 
            this.txt_Tai_Khoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tai_Khoan.Location = new System.Drawing.Point(174, 18);
            this.txt_Tai_Khoan.Name = "txt_Tai_Khoan";
            this.txt_Tai_Khoan.Size = new System.Drawing.Size(555, 44);
            this.txt_Tai_Khoan.TabIndex = 2;
            this.txt_Tai_Khoan.Text = "tranconghai2003@gmail.com";
            // 
            // txt_Mat_Khau
            // 
            this.txt_Mat_Khau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mat_Khau.Location = new System.Drawing.Point(174, 74);
            this.txt_Mat_Khau.Name = "txt_Mat_Khau";
            this.txt_Mat_Khau.PasswordChar = '*';
            this.txt_Mat_Khau.Size = new System.Drawing.Size(555, 44);
            this.txt_Mat_Khau.TabIndex = 3;
            this.txt_Mat_Khau.Text = "etwcpzwcghhjvvcg";
            // 
            // txt_Port_IMAP
            // 
            this.txt_Port_IMAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Port_IMAP.Location = new System.Drawing.Point(927, 74);
            this.txt_Port_IMAP.Name = "txt_Port_IMAP";
            this.txt_Port_IMAP.Size = new System.Drawing.Size(332, 44);
            this.txt_Port_IMAP.TabIndex = 7;
            this.txt_Port_IMAP.Text = "993";
            // 
            // txt_IMAP
            // 
            this.txt_IMAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IMAP.Location = new System.Drawing.Point(927, 18);
            this.txt_IMAP.Name = "txt_IMAP";
            this.txt_IMAP.Size = new System.Drawing.Size(332, 44);
            this.txt_IMAP.TabIndex = 6;
            this.txt_IMAP.Text = "imap.gmail.com";
            // 
            // lb_Port_IMAP
            // 
            this.lb_Port_IMAP.AutoSize = true;
            this.lb_Port_IMAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Port_IMAP.Location = new System.Drawing.Point(824, 76);
            this.lb_Port_IMAP.Name = "lb_Port_IMAP";
            this.lb_Port_IMAP.Size = new System.Drawing.Size(76, 37);
            this.lb_Port_IMAP.TabIndex = 5;
            this.lb_Port_IMAP.Text = "Port";
            // 
            // lb_IMAP
            // 
            this.lb_IMAP.AutoSize = true;
            this.lb_IMAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IMAP.Location = new System.Drawing.Point(824, 23);
            this.lb_IMAP.Name = "lb_IMAP";
            this.lb_IMAP.Size = new System.Drawing.Size(94, 37);
            this.lb_IMAP.TabIndex = 4;
            this.lb_IMAP.Text = "IMAP";
            // 
            // txt_Port_SMTP
            // 
            this.txt_Port_SMTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Port_SMTP.Location = new System.Drawing.Point(1446, 76);
            this.txt_Port_SMTP.Name = "txt_Port_SMTP";
            this.txt_Port_SMTP.Size = new System.Drawing.Size(332, 44);
            this.txt_Port_SMTP.TabIndex = 11;
            this.txt_Port_SMTP.Text = "587";
            // 
            // txt_SMTP
            // 
            this.txt_SMTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SMTP.Location = new System.Drawing.Point(1446, 20);
            this.txt_SMTP.Name = "txt_SMTP";
            this.txt_SMTP.Size = new System.Drawing.Size(332, 44);
            this.txt_SMTP.TabIndex = 10;
            this.txt_SMTP.Text = "smtp.gmail.com";
            // 
            // lb_Port_SMTP
            // 
            this.lb_Port_SMTP.AutoSize = true;
            this.lb_Port_SMTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Port_SMTP.Location = new System.Drawing.Point(1335, 73);
            this.lb_Port_SMTP.Name = "lb_Port_SMTP";
            this.lb_Port_SMTP.Size = new System.Drawing.Size(76, 37);
            this.lb_Port_SMTP.TabIndex = 9;
            this.lb_Port_SMTP.Text = "Port";
            // 
            // lb_SMTP
            // 
            this.lb_SMTP.AutoSize = true;
            this.lb_SMTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SMTP.Location = new System.Drawing.Point(1330, 20);
            this.lb_SMTP.Name = "lb_SMTP";
            this.lb_SMTP.Size = new System.Drawing.Size(105, 37);
            this.lb_SMTP.TabIndex = 8;
            this.lb_SMTP.Text = "SMTP";
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(12, 126);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(329, 66);
            this.btn_Login.TabIndex = 12;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(496, 126);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(329, 66);
            this.btn_Logout.TabIndex = 13;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Visible = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Location = new System.Drawing.Point(968, 126);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(329, 66);
            this.btn_Send.TabIndex = 14;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Visible = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(1446, 126);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(332, 66);
            this.btn_Refresh.TabIndex = 15;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Visible = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lv_mails
            // 
            this.lv_mails.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lv_mails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No_of_mail,
            this.Source,
            this.Title,
            this.Time});
            this.lv_mails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_mails.FullRowSelect = true;
            this.lv_mails.HideSelection = false;
            this.lv_mails.Location = new System.Drawing.Point(12, 215);
            this.lv_mails.Name = "lv_mails";
            this.lv_mails.Size = new System.Drawing.Size(1766, 765);
            this.lv_mails.TabIndex = 16;
            this.lv_mails.UseCompatibleStateImageBehavior = false;
            this.lv_mails.View = System.Windows.Forms.View.Details;
            this.lv_mails.Click += new System.EventHandler(this.lv_mails_Click);
            // 
            // No_of_mail
            // 
            this.No_of_mail.Text = "#";
            // 
            // Source
            // 
            this.Source.Text = "From";
            this.Source.Width = 432;
            // 
            // Title
            // 
            this.Title.Text = "Subject";
            this.Title.Width = 372;
            // 
            // Time
            // 
            this.Time.Text = "Datetime";
            this.Time.Width = 293;
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1790, 992);
            this.Controls.Add(this.lv_mails);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Port_SMTP);
            this.Controls.Add(this.txt_SMTP);
            this.Controls.Add(this.lb_Port_SMTP);
            this.Controls.Add(this.lb_SMTP);
            this.Controls.Add(this.txt_Port_IMAP);
            this.Controls.Add(this.txt_IMAP);
            this.Controls.Add(this.lb_Port_IMAP);
            this.Controls.Add(this.lb_IMAP);
            this.Controls.Add(this.txt_Mat_Khau);
            this.Controls.Add(this.txt_Tai_Khoan);
            this.Controls.Add(this.lb_Mat_Khau);
            this.Controls.Add(this.lb_Tai_Khoan);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Tai_Khoan;
        private System.Windows.Forms.Label lb_Mat_Khau;
        private System.Windows.Forms.TextBox txt_Tai_Khoan;
        private System.Windows.Forms.TextBox txt_Mat_Khau;
        private System.Windows.Forms.TextBox txt_Port_IMAP;
        private System.Windows.Forms.TextBox txt_IMAP;
        private System.Windows.Forms.Label lb_Port_IMAP;
        private System.Windows.Forms.Label lb_IMAP;
        private System.Windows.Forms.TextBox txt_Port_SMTP;
        private System.Windows.Forms.TextBox txt_SMTP;
        private System.Windows.Forms.Label lb_Port_SMTP;
        private System.Windows.Forms.Label lb_SMTP;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ListView lv_mails;
        private System.Windows.Forms.ColumnHeader No_of_mail;
        private System.Windows.Forms.ColumnHeader Source;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Time;
    }
}

