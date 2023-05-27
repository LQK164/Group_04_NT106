namespace Lab4_WebBrowser
{
    partial class Resource
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
            this.tbViewSource = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbViewSource
            // 
            this.tbViewSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbViewSource.Location = new System.Drawing.Point(0, 0);
            this.tbViewSource.Multiline = true;
            this.tbViewSource.Name = "tbViewSource";
            this.tbViewSource.Size = new System.Drawing.Size(800, 450);
            this.tbViewSource.TabIndex = 0;
            // 
            // Resource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbViewSource);
            this.Name = "Resource";
            this.Text = "ViewSource";
            this.Load += new System.EventHandler(this.Resource_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbViewSource;
    }
}