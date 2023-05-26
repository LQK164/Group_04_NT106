namespace Bai4
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
            btn_previous = new Button();
            btn_next = new Button();
            lb_user_list = new Label();
            lb_page = new Label();
            Page = new Label();
            label4 = new Label();
            user_per_page = new Label();
            lb_total_pages = new Label();
            total_pages = new Label();
            lb_total_users = new Label();
            total_users = new Label();
            progressBar = new ProgressBar();
            panel1 = new Panel();
            flpn_upload = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_previous
            // 
            btn_previous.Location = new Point(448, 41);
            btn_previous.Name = "btn_previous";
            btn_previous.Size = new Size(112, 34);
            btn_previous.TabIndex = 0;
            btn_previous.Text = "previous";
            btn_previous.UseVisualStyleBackColor = true;
            btn_previous.Click += btn_previous_Click;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(666, 41);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(112, 34);
            btn_next.TabIndex = 1;
            btn_next.Text = "next";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // lb_user_list
            // 
            lb_user_list.AutoSize = true;
            lb_user_list.Location = new Point(581, 46);
            lb_user_list.Name = "lb_user_list";
            lb_user_list.Size = new Size(72, 25);
            lb_user_list.TabIndex = 2;
            lb_user_list.Text = "user list";
            // 
            // lb_page
            // 
            lb_page.AutoSize = true;
            lb_page.Location = new Point(20, 9);
            lb_page.Name = "lb_page";
            lb_page.Size = new Size(54, 25);
            lb_page.TabIndex = 3;
            lb_page.Text = "Page:";
            // 
            // Page
            // 
            Page.AutoSize = true;
            Page.Location = new Point(131, 9);
            Page.Name = "Page";
            Page.Size = new Size(0, 25);
            Page.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 50);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 5;
            label4.Text = "Users/page:";
            // 
            // user_per_page
            // 
            user_per_page.AutoSize = true;
            user_per_page.Location = new Point(131, 50);
            user_per_page.Name = "user_per_page";
            user_per_page.Size = new Size(0, 25);
            user_per_page.TabIndex = 6;
            // 
            // lb_total_pages
            // 
            lb_total_pages.AutoSize = true;
            lb_total_pages.Location = new Point(227, 9);
            lb_total_pages.Name = "lb_total_pages";
            lb_total_pages.Size = new Size(111, 25);
            lb_total_pages.TabIndex = 7;
            lb_total_pages.Text = "Total pages: ";
            // 
            // total_pages
            // 
            total_pages.AutoSize = true;
            total_pages.Location = new Point(336, 8);
            total_pages.Name = "total_pages";
            total_pages.Size = new Size(0, 25);
            total_pages.TabIndex = 8;
            // 
            // lb_total_users
            // 
            lb_total_users.AutoSize = true;
            lb_total_users.Location = new Point(227, 50);
            lb_total_users.Name = "lb_total_users";
            lb_total_users.Size = new Size(104, 25);
            lb_total_users.TabIndex = 9;
            lb_total_users.Text = "Total users: ";
            // 
            // total_users
            // 
            total_users.AutoSize = true;
            total_users.Location = new Point(336, 50);
            total_users.Name = "total_users";
            total_users.Size = new Size(0, 25);
            total_users.TabIndex = 10;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 408);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(766, 30);
            progressBar.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(flpn_upload);
            panel1.Location = new Point(20, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(758, 245);
            panel1.TabIndex = 12;
            // 
            // flpn_upload
            // 
            flpn_upload.AutoScroll = true;
            flpn_upload.Dock = DockStyle.Bottom;
            flpn_upload.FlowDirection = FlowDirection.TopDown;
            flpn_upload.Location = new Point(0, 0);
            flpn_upload.Name = "flpn_upload";
            flpn_upload.Size = new Size(758, 245);
            flpn_upload.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(progressBar);
            Controls.Add(total_users);
            Controls.Add(lb_total_users);
            Controls.Add(total_pages);
            Controls.Add(lb_total_pages);
            Controls.Add(user_per_page);
            Controls.Add(label4);
            Controls.Add(Page);
            Controls.Add(lb_page);
            Controls.Add(lb_user_list);
            Controls.Add(btn_next);
            Controls.Add(btn_previous);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_previous;
        private Button btn_next;
        private Label lb_user_list;
        private Label lb_page;
        private Label Page;
        private Label label4;
        private Label user_per_page;
        private Label lb_total_pages;
        private Label total_pages;
        private Label lb_total_users;
        private Label total_users;
        private ProgressBar progressBar;
        private Panel panel1;
        private FlowLayoutPanel flpn_upload;
    }
}