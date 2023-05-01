namespace Telnet_TCP_listener
{
    partial class TCPlistener
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
            this.listen = new System.Windows.Forms.Button();
            this.listViewCommand = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listen
            // 
            this.listen.AutoSize = true;
            this.listen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listen.Location = new System.Drawing.Point(460, 55);
            this.listen.Name = "listen";
            this.listen.Size = new System.Drawing.Size(107, 32);
            this.listen.TabIndex = 0;
            this.listen.Text = "Listen ";
            this.listen.UseVisualStyleBackColor = false;
            this.listen.Click += new System.EventHandler(this.listen_Click);
            // 
            // listViewCommand
            // 
            this.listViewCommand.HideSelection = false;
            this.listViewCommand.Location = new System.Drawing.Point(22, 104);
            this.listViewCommand.Name = "listViewCommand";
            this.listViewCommand.Size = new System.Drawing.Size(545, 325);
            this.listViewCommand.TabIndex = 1;
            this.listViewCommand.UseCompatibleStateImageBehavior = false;
            // 
            // TCPlistener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.listViewCommand);
            this.Controls.Add(this.listen);
            this.Name = "TCPlistener";
            this.Text = "TCP Listener ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listen;
        private System.Windows.Forms.ListView listViewCommand;
    }
}

