namespace Bai4
{
    partial class Mail_detail
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
            this.lb_From = new System.Windows.Forms.Label();
            this.txt_From = new System.Windows.Forms.TextBox();
            this.txt_To = new System.Windows.Forms.TextBox();
            this.lb_To = new System.Windows.Forms.Label();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.txt_Mail_Content = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // lb_From
            // 
            this.lb_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_From.Location = new System.Drawing.Point(12, 33);
            this.lb_From.Name = "lb_From";
            this.lb_From.Size = new System.Drawing.Size(108, 35);
            this.lb_From.TabIndex = 0;
            this.lb_From.Text = "From:";
            // 
            // txt_From
            // 
            this.txt_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_From.Location = new System.Drawing.Point(136, 30);
            this.txt_From.Name = "txt_From";
            this.txt_From.ReadOnly = true;
            this.txt_From.Size = new System.Drawing.Size(1016, 44);
            this.txt_From.TabIndex = 1;
            // 
            // txt_To
            // 
            this.txt_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_To.Location = new System.Drawing.Point(136, 94);
            this.txt_To.Name = "txt_To";
            this.txt_To.ReadOnly = true;
            this.txt_To.Size = new System.Drawing.Size(1016, 44);
            this.txt_To.TabIndex = 3;
            // 
            // lb_To
            // 
            this.lb_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_To.Location = new System.Drawing.Point(12, 97);
            this.lb_To.Name = "lb_To";
            this.lb_To.Size = new System.Drawing.Size(108, 35);
            this.lb_To.TabIndex = 2;
            this.lb_To.Text = "To:";
            // 
            // txt_Subject
            // 
            this.txt_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Subject.Location = new System.Drawing.Point(12, 169);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.ReadOnly = true;
            this.txt_Subject.Size = new System.Drawing.Size(1140, 44);
            this.txt_Subject.TabIndex = 4;
            // 
            // txt_Mail_Content
            // 
            this.txt_Mail_Content.Location = new System.Drawing.Point(12, 231);
            this.txt_Mail_Content.MinimumSize = new System.Drawing.Size(20, 20);
            this.txt_Mail_Content.Name = "txt_Mail_Content";
            this.txt_Mail_Content.Size = new System.Drawing.Size(1140, 407);
            this.txt_Mail_Content.TabIndex = 5;
            // 
            // Mail_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 650);
            this.Controls.Add(this.txt_Mail_Content);
            this.Controls.Add(this.txt_Subject);
            this.Controls.Add(this.txt_To);
            this.Controls.Add(this.lb_To);
            this.Controls.Add(this.txt_From);
            this.Controls.Add(this.lb_From);
            this.Name = "Mail_detail";
            this.Load += new System.EventHandler(this.Mail_detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_From;
        private System.Windows.Forms.TextBox txt_From;
        private System.Windows.Forms.TextBox txt_To;
        private System.Windows.Forms.Label lb_To;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.WebBrowser txt_Mail_Content;
    }
}