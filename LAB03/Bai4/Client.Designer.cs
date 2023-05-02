namespace Bai4
{
    partial class frmClient
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
            this.grbParticipants = new System.Windows.Forms.GroupBox();
            this.lstParticipants = new System.Windows.Forms.ListBox();
            this.lstChatBox = new System.Windows.Forms.ListBox();
            this.grbUsername = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.grbMessage = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.grbParticipants.SuspendLayout();
            this.grbUsername.SuspendLayout();
            this.grbMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbParticipants
            // 
            this.grbParticipants.Controls.Add(this.lstParticipants);
            this.grbParticipants.Location = new System.Drawing.Point(657, 12);
            this.grbParticipants.Name = "grbParticipants";
            this.grbParticipants.Size = new System.Drawing.Size(137, 454);
            this.grbParticipants.TabIndex = 0;
            this.grbParticipants.TabStop = false;
            this.grbParticipants.Text = "Participants";
            // 
            // lstParticipants
            // 
            this.lstParticipants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstParticipants.FormattingEnabled = true;
            this.lstParticipants.ItemHeight = 18;
            this.lstParticipants.Location = new System.Drawing.Point(3, 18);
            this.lstParticipants.Name = "lstParticipants";
            this.lstParticipants.Size = new System.Drawing.Size(131, 433);
            this.lstParticipants.TabIndex = 0;
            this.lstParticipants.SelectedIndexChanged += new System.EventHandler(this.lstParticipants_SelectedIndexChanged);
            // 
            // lstChatBox
            // 
            this.lstChatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstChatBox.FormattingEnabled = true;
            this.lstChatBox.ItemHeight = 18;
            this.lstChatBox.Location = new System.Drawing.Point(4, 12);
            this.lstChatBox.Name = "lstChatBox";
            this.lstChatBox.Size = new System.Drawing.Size(647, 292);
            this.lstChatBox.TabIndex = 1;
            // 
            // grbUsername
            // 
            this.grbUsername.Controls.Add(this.btnConnect);
            this.grbUsername.Controls.Add(this.txtUsername);
            this.grbUsername.Location = new System.Drawing.Point(4, 310);
            this.grbUsername.Name = "grbUsername";
            this.grbUsername.Size = new System.Drawing.Size(647, 69);
            this.grbUsername.TabIndex = 2;
            this.grbUsername.TabStop = false;
            this.grbUsername.Text = "Username";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(216, 27);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(90, 33);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(8, 31);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(163, 24);
            this.txtUsername.TabIndex = 0;
            // 
            // grbMessage
            // 
            this.grbMessage.Controls.Add(this.btnSend);
            this.grbMessage.Controls.Add(this.txtMessage);
            this.grbMessage.Location = new System.Drawing.Point(4, 385);
            this.grbMessage.Name = "grbMessage";
            this.grbMessage.Size = new System.Drawing.Size(647, 81);
            this.grbMessage.TabIndex = 3;
            this.grbMessage.TabStop = false;
            this.grbMessage.Text = "Message";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(483, 21);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(116, 54);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(3, 18);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(446, 60);
            this.txtMessage.TabIndex = 0;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.grbMessage);
            this.Controls.Add(this.grbUsername);
            this.Controls.Add(this.lstChatBox);
            this.Controls.Add(this.grbParticipants);
            this.Name = "frmClient";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClient_FormClosing);
            this.grbParticipants.ResumeLayout(false);
            this.grbUsername.ResumeLayout(false);
            this.grbUsername.PerformLayout();
            this.grbMessage.ResumeLayout(false);
            this.grbMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbParticipants;
        private System.Windows.Forms.ListBox lstChatBox;
        private System.Windows.Forms.GroupBox grbUsername;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox grbMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ListBox lstParticipants;
    }
}