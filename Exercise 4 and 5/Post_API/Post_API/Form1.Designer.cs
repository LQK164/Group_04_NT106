namespace Post_API
{
    partial class Form1
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
            url = new Label();
            email = new Label();
            password = new Label();
            txt_pass = new TextBox();
            txt_email = new TextBox();
            txt_url = new TextBox();
            txt_response = new RichTextBox();
            btnPost = new Button();
            SuspendLayout();
            // 
            // url
            // 
            url.AutoSize = true;
            url.Location = new Point(35, 65);
            url.Name = "url";
            url.Size = new Size(47, 25);
            url.TabIndex = 0;
            url.Text = "URL:";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(35, 141);
            email.Name = "email";
            email.Size = new Size(65, 25);
            email.TabIndex = 1;
            email.Text = "E-mail:";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(35, 228);
            password.Name = "password";
            password.Size = new Size(91, 25);
            password.TabIndex = 2;
            password.Text = "Password:";
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(163, 222);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(532, 31);
            txt_pass.TabIndex = 3;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(163, 135);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(532, 31);
            txt_email.TabIndex = 4;
            // 
            // txt_url
            // 
            txt_url.Location = new Point(163, 59);
            txt_url.Name = "txt_url";
            txt_url.Size = new Size(532, 31);
            txt_url.TabIndex = 5;
            // 
            // txt_response
            // 
            txt_response.Location = new Point(35, 282);
            txt_response.Name = "txt_response";
            txt_response.Size = new Size(630, 156);
            txt_response.TabIndex = 6;
            txt_response.Text = "";
            // 
            // btnPost
            // 
            btnPost.Location = new Point(676, 282);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(112, 34);
            btnPost.TabIndex = 7;
            btnPost.Text = "Post";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPost);
            Controls.Add(txt_response);
            Controls.Add(txt_url);
            Controls.Add(txt_email);
            Controls.Add(txt_pass);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(url);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label url;
        private Label email;
        private Label password;
        private TextBox txt_pass;
        private TextBox txt_email;
        private TextBox txt_url;
        private RichTextBox txt_response;
        private Button btnPost;
    }
}