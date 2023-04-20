namespace CallAPI
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
            txtResponse = new RichTextBox();
            btnGetAll = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtResponse
            // 
            txtResponse.Location = new Point(186, 12);
            txtResponse.Name = "txtResponse";
            txtResponse.Size = new Size(602, 426);
            txtResponse.TabIndex = 3;
            txtResponse.Text = "";
            // 
            // btnGetAll
            // 
            btnGetAll.Location = new Point(12, 12);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(141, 80);
            btnGetAll.TabIndex = 4;
            btnGetAll.Text = "Get all";
            btnGetAll.UseVisualStyleBackColor = true;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 190);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(141, 80);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnGetAll);
            Controls.Add(txtResponse);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox txtResponse;
        private Button btnGetAll;
        private Button btnDelete;
    }
}