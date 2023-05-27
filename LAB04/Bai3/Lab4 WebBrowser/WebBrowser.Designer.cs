namespace Lab4_WebBrowser
{
    partial class WebBrowser
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.pnWeb = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDowHTML = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnViewSource = new System.Windows.Forms.Button();
            this.pnWeb.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 31);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add WebBrowser";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGo
            // 
            this.btnGo.AutoSize = true;
            this.btnGo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGo.Location = new System.Drawing.Point(132, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(64, 31);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(202, 3);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(1075, 31);
            this.tbAddress.TabIndex = 2;
            // 
            // pnWeb
            // 
            this.pnWeb.Controls.Add(this.btnAdd);
            this.pnWeb.Controls.Add(this.btnGo);
            this.pnWeb.Controls.Add(this.tbAddress);
            this.pnWeb.Controls.Add(this.btnDowHTML);
            this.pnWeb.Controls.Add(this.btnViewSource);
            this.pnWeb.Controls.Add(this.tbPath);
            this.pnWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnWeb.Location = new System.Drawing.Point(0, 0);
            this.pnWeb.Name = "pnWeb";
            this.pnWeb.Size = new System.Drawing.Size(1323, 590);
            this.pnWeb.TabIndex = 3;
            // 
            // btnDowHTML
            // 
            this.btnDowHTML.AutoSize = true;
            this.btnDowHTML.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDowHTML.Location = new System.Drawing.Point(3, 40);
            this.btnDowHTML.Name = "btnDowHTML";
            this.btnDowHTML.Size = new System.Drawing.Size(123, 31);
            this.btnDowHTML.TabIndex = 4;
            this.btnDowHTML.Text = "Download HTML ";
            this.btnDowHTML.UseVisualStyleBackColor = false;
            this.btnDowHTML.Click += new System.EventHandler(this.btnDowHTML_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(261, 40);
            this.tbPath.Multiline = true;
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(1016, 31);
            this.tbPath.TabIndex = 5;
            // 
            // btnViewSource
            // 
            this.btnViewSource.AutoSize = true;
            this.btnViewSource.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewSource.Location = new System.Drawing.Point(132, 40);
            this.btnViewSource.Name = "btnViewSource";
            this.btnViewSource.Size = new System.Drawing.Size(123, 31);
            this.btnViewSource.TabIndex = 6;
            this.btnViewSource.Text = "ViewSource";
            this.btnViewSource.UseVisualStyleBackColor = false;
            this.btnViewSource.Click += new System.EventHandler(this.btnViewSource_Click);
            // 
            // WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 590);
            this.Controls.Add(this.pnWeb);
            this.Name = "WebBrowser";
            this.Text = "Form1";
            this.pnWeb.ResumeLayout(false);
            this.pnWeb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.FlowLayoutPanel pnWeb;
        private System.Windows.Forms.Button btnDowHTML;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnViewSource;
    }
}

