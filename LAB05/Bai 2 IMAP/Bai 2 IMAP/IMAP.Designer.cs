namespace Bai_2_IMAP
{
    partial class IMAP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_mail = new Label();
            lb_pass = new Label();
            txt_password = new TextBox();
            txt_email = new TextBox();
            btn_login = new Button();
            lb_total = new Label();
            lb_recent = new Label();
            lb_show_total = new Label();
            lb_show_recent = new Label();
            cb_show_pass = new CheckBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lb_mail
            // 
            lb_mail.AutoSize = true;
            lb_mail.Location = new Point(22, 9);
            lb_mail.Name = "lb_mail";
            lb_mail.Size = new Size(58, 25);
            lb_mail.TabIndex = 0;
            lb_mail.Text = "Email:";
            // 
            // lb_pass
            // 
            lb_pass.AutoSize = true;
            lb_pass.Location = new Point(22, 79);
            lb_pass.Name = "lb_pass";
            lb_pass.Size = new Size(91, 25);
            lb_pass.TabIndex = 1;
            lb_pass.Text = "Password:";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(115, 73);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(297, 31);
            txt_password.TabIndex = 2;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(115, 3);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(297, 31);
            txt_email.TabIndex = 3;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(560, 30);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(147, 45);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // lb_total
            // 
            lb_total.AutoSize = true;
            lb_total.Location = new Point(22, 156);
            lb_total.Name = "lb_total";
            lb_total.Size = new Size(53, 25);
            lb_total.TabIndex = 5;
            lb_total.Text = "Total:";
            // 
            // lb_recent
            // 
            lb_recent.AutoSize = true;
            lb_recent.Location = new Point(207, 156);
            lb_recent.Name = "lb_recent";
            lb_recent.Size = new Size(68, 25);
            lb_recent.TabIndex = 6;
            lb_recent.Text = "Recent:";
            // 
            // lb_show_total
            // 
            lb_show_total.AutoSize = true;
            lb_show_total.Location = new Point(104, 156);
            lb_show_total.Name = "lb_show_total";
            lb_show_total.Size = new Size(0, 25);
            lb_show_total.TabIndex = 8;
            // 
            // lb_show_recent
            // 
            lb_show_recent.AutoSize = true;
            lb_show_recent.Location = new Point(304, 156);
            lb_show_recent.Name = "lb_show_recent";
            lb_show_recent.Size = new Size(0, 25);
            lb_show_recent.TabIndex = 9;
            // 
            // cb_show_pass
            // 
            cb_show_pass.AutoSize = true;
            cb_show_pass.Location = new Point(291, 124);
            cb_show_pass.Name = "cb_show_pass";
            cb_show_pass.Size = new Size(164, 29);
            cb_show_pass.TabIndex = 10;
            cb_show_pass.Text = "Show password";
            cb_show_pass.UseVisualStyleBackColor = true;
            cb_show_pass.CheckedChanged += cb_show_pass_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(753, 225);
            dataGridView1.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(cb_show_pass);
            Controls.Add(lb_show_recent);
            Controls.Add(lb_show_total);
            Controls.Add(lb_recent);
            Controls.Add(lb_total);
            Controls.Add(btn_login);
            Controls.Add(txt_email);
            Controls.Add(txt_password);
            Controls.Add(lb_pass);
            Controls.Add(lb_mail);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_mail;
        private Label lb_pass;
        private TextBox txt_password;
        private TextBox txt_email;
        private Button btn_login;
        private Label lb_total;
        private Label lb_recent;
        private Label lb_show_total;
        private Label lb_show_recent;
        private CheckBox cb_show_pass;
        private DataGridView dataGridView1;
    }
}