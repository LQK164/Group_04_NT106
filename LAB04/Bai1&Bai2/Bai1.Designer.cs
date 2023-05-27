namespace Bai1_Bai2
{
    partial class Bai1
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
            this.txt_Content = new System.Windows.Forms.RichTextBox();
            this.btn_Get = new System.Windows.Forms.Button();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Content
            // 
            this.txt_Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Content.Location = new System.Drawing.Point(12, 63);
            this.txt_Content.Name = "txt_Content";
            this.txt_Content.Size = new System.Drawing.Size(1035, 472);
            this.txt_Content.TabIndex = 5;
            this.txt_Content.Text = "";
            // 
            // btn_Get
            // 
            this.btn_Get.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Get.Location = new System.Drawing.Point(854, 13);
            this.btn_Get.Name = "btn_Get";
            this.btn_Get.Size = new System.Drawing.Size(193, 45);
            this.btn_Get.TabIndex = 4;
            this.btn_Get.Text = "Get";
            this.btn_Get.UseVisualStyleBackColor = true;
            this.btn_Get.Click += new System.EventHandler(this.btn_Get_Click);
            // 
            // txt_URL
            // 
            this.txt_URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_URL.Location = new System.Drawing.Point(11, 13);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(837, 44);
            this.txt_URL.TabIndex = 3;
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 551);
            this.Controls.Add(this.txt_Content);
            this.Controls.Add(this.btn_Get);
            this.Controls.Add(this.txt_URL);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_Content;
        private System.Windows.Forms.Button btn_Get;
        private System.Windows.Forms.TextBox txt_URL;
    }
}

