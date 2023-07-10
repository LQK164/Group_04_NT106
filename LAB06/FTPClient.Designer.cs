namespace LAB06
{
    partial class frmLab6
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("..");
            this.lblServerIP = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.grbDisplay = new System.Windows.Forms.GroupBox();
            this.lvDisplay = new System.Windows.Forms.ListView();
            this.clnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btn_Rename = new System.Windows.Forms.Button();
            this.btn_Time = new System.Windows.Forms.Button();
            this.btn_Size = new System.Windows.Forms.Button();
            this.txt_New_name = new System.Windows.Forms.TextBox();
            this.lblNewFileName = new System.Windows.Forms.Label();
            this.grbDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerIP.Location = new System.Drawing.Point(20, 30);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(152, 25);
            this.lblServerIP.TabIndex = 0;
            this.lblServerIP.Text = "FTP Server IP:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(55, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(55, 121);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(112, 25);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerIP.Location = new System.Drawing.Point(170, 26);
            this.txtServerIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(206, 31);
            this.txtServerIP.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(170, 74);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(206, 31);
            this.txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(170, 118);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(206, 31);
            this.txtPassword.TabIndex = 5;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(17, 194);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(126, 41);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // grbDisplay
            // 
            this.grbDisplay.Controls.Add(this.lvDisplay);
            this.grbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDisplay.Location = new System.Drawing.Point(14, 250);
            this.grbDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDisplay.Name = "grbDisplay";
            this.grbDisplay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDisplay.Size = new System.Drawing.Size(1083, 298);
            this.grbDisplay.TabIndex = 7;
            this.grbDisplay.TabStop = false;
            this.grbDisplay.Text = "Remote Site";
            // 
            // lvDisplay
            // 
            this.lvDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnName,
            this.clnSize,
            this.clnDate,
            this.clnType});
            this.lvDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDisplay.GridLines = true;
            this.lvDisplay.HideSelection = false;
            this.lvDisplay.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvDisplay.Location = new System.Drawing.Point(3, 25);
            this.lvDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvDisplay.Name = "lvDisplay";
            this.lvDisplay.Size = new System.Drawing.Size(1077, 269);
            this.lvDisplay.TabIndex = 0;
            this.lvDisplay.UseCompatibleStateImageBehavior = false;
            this.lvDisplay.View = System.Windows.Forms.View.Details;
            this.lvDisplay.DoubleClick += new System.EventHandler(this.lvDisplay_DoubleClick);
            // 
            // clnName
            // 
            this.clnName.Text = "Name";
            this.clnName.Width = 527;
            // 
            // clnSize
            // 
            this.clnSize.Text = "Size";
            this.clnSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnSize.Width = 86;
            // 
            // clnDate
            // 
            this.clnDate.Text = "Last Modified";
            this.clnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnDate.Width = 183;
            // 
            // clnType
            // 
            this.clnType.Text = "Type";
            this.clnType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnType.Width = 159;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(209, 194);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(126, 41);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(402, 194);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(126, 41);
            this.btnDownload.TabIndex = 9;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(594, 194);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(126, 41);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btn_Rename
            // 
            this.btn_Rename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rename.Location = new System.Drawing.Point(948, 194);
            this.btn_Rename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Rename.Name = "btn_Rename";
            this.btn_Rename.Size = new System.Drawing.Size(146, 41);
            this.btn_Rename.TabIndex = 11;
            this.btn_Rename.Text = "Rename File";
            this.btn_Rename.UseVisualStyleBackColor = true;
            this.btn_Rename.Click += new System.EventHandler(this.btn_Rename_Click);
            // 
            // btn_Time
            // 
            this.btn_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Time.Location = new System.Drawing.Point(773, 194);
            this.btn_Time.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Time.Name = "btn_Time";
            this.btn_Time.Size = new System.Drawing.Size(126, 41);
            this.btn_Time.TabIndex = 12;
            this.btn_Time.Text = "Get Time";
            this.btn_Time.UseVisualStyleBackColor = true;
            this.btn_Time.Click += new System.EventHandler(this.btn_Get_Time_Click);
            // 
            // btn_Size
            // 
            this.btn_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Size.Location = new System.Drawing.Point(802, 135);
            this.btn_Size.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Size.Name = "btn_Size";
            this.btn_Size.Size = new System.Drawing.Size(292, 41);
            this.btn_Size.TabIndex = 13;
            this.btn_Size.Text = "Get Size File";
            this.btn_Size.UseVisualStyleBackColor = true;
            this.btn_Size.Click += new System.EventHandler(this.btn_Size_Click);
            // 
            // txt_New_name
            // 
            this.txt_New_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_New_name.Location = new System.Drawing.Point(568, 27);
            this.txt_New_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_New_name.Name = "txt_New_name";
            this.txt_New_name.Size = new System.Drawing.Size(206, 31);
            this.txt_New_name.TabIndex = 15;
            // 
            // lblNewFileName
            // 
            this.lblNewFileName.AutoSize = true;
            this.lblNewFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewFileName.Location = new System.Drawing.Point(399, 31);
            this.lblNewFileName.Name = "lblNewFileName";
            this.lblNewFileName.Size = new System.Drawing.Size(163, 25);
            this.lblNewFileName.TabIndex = 14;
            this.lblNewFileName.Text = "New File Name:";
            // 
            // frmLab6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 562);
            this.Controls.Add(this.txt_New_name);
            this.Controls.Add(this.lblNewFileName);
            this.Controls.Add(this.btn_Size);
            this.Controls.Add(this.btn_Time);
            this.Controls.Add(this.btn_Rename);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.grbDisplay);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblServerIP);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLab6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTP Client";
            this.grbDisplay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox grbDisplay;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ListView lvDisplay;
        private System.Windows.Forms.ColumnHeader clnName;
        private System.Windows.Forms.ColumnHeader clnSize;
        private System.Windows.Forms.ColumnHeader clnDate;
        private System.Windows.Forms.ColumnHeader clnType;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btn_Rename;
        private System.Windows.Forms.Button btn_Time;
        private System.Windows.Forms.Button btn_Size;
        private System.Windows.Forms.TextBox txt_New_name;
        private System.Windows.Forms.Label lblNewFileName;
    }
}

