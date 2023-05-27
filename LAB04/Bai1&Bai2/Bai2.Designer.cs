namespace Bai1_Bai2
{
    partial class Bai2
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
            this.txt_Destination = new System.Windows.Forms.TextBox();
            this.txt_Content = new System.Windows.Forms.RichTextBox();
            this.btn_Download = new System.Windows.Forms.Button();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Destination
            // 
            this.txt_Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Destination.Location = new System.Drawing.Point(12, 58);
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.Size = new System.Drawing.Size(670, 44);
            this.txt_Destination.TabIndex = 10;
            // 
            // txt_Content
            // 
            this.txt_Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Content.Location = new System.Drawing.Point(12, 108);
            this.txt_Content.Name = "txt_Content";
            this.txt_Content.Size = new System.Drawing.Size(908, 372);
            this.txt_Content.TabIndex = 9;
            this.txt_Content.Text = "";
            // 
            // btn_Download
            // 
            this.btn_Download.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Download.Location = new System.Drawing.Point(688, 8);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(232, 95);
            this.btn_Download.TabIndex = 8;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // txt_URL
            // 
            this.txt_URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_URL.Location = new System.Drawing.Point(12, 8);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(670, 44);
            this.txt_URL.TabIndex = 7;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 492);
            this.Controls.Add(this.txt_Destination);
            this.Controls.Add(this.txt_Content);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.txt_URL);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Destination;
        private System.Windows.Forms.RichTextBox txt_Content;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.TextBox txt_URL;
    }
}