﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB06
{
    public partial class frmLab6 : Form
    {
        public frmLab6()
        {
            InitializeComponent();
        }

        private int buffer_size = 2048;
        private string uri = "";
        private string current_folder = "";
        private string last_folder = "";
        private string file = "";

        private void frmLab6_Load(object sender, EventArgs e)
        {
            btnUpload.Enabled = false;
            btnDownload.Enabled = false;
            btnRefresh.Enabled = false;
            btnGetDate.Enabled = false;
            btnRename.Enabled = false;
            btnGetSize.Enabled = false;
        }

        private string GetUri(string folder, string file)
        {
            return $"ftp://{txtServerIP.Text}/{folder}{file}";
        }

        private void ClearDisplay()
        {
            while (lvDisplay.Items.Count > 1)
            {
                lvDisplay.Items.RemoveAt(1);
            }
        }

        private void DisplayDetails(string uri)
        {
            List<string> lines = new List<string>();

            FtpWebRequest ftp_request = (FtpWebRequest)WebRequest.Create(new Uri(uri));
            ftp_request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            ftp_request.Credentials = new NetworkCredential(txtUsername.Text, txtPassword.Text);

            FtpWebResponse ftp_response = (FtpWebResponse)ftp_request.GetResponse();
            Stream ftp_stream = ftp_response.GetResponseStream();
            StreamReader sr = new StreamReader(ftp_stream);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                lines.Add(line);
            }

            foreach (string line in lines)
            {
                string[] tokens = line.Split(new string[] { " " }, 9, StringSplitOptions.RemoveEmptyEntries);
                ListViewItem token = new ListViewItem(tokens[8]);
                int size = int.Parse(tokens[4]);

                if (size > 0 && size < 1024)
                {
                    token.SubItems.Add("1 KB");
                }
                else
                {
                    token.SubItems.Add(size / 1024 + " KB");
                }

                token.SubItems.Add($"{tokens[5]} {tokens[6]} {tokens[7]}");

                if (tokens[0].Substring(0, 1) == "d")
                {
                    token.SubItems.Add("Folder");
                }
                else
                {
                    token.SubItems.Add(tokens[8].Substring(tokens[8].LastIndexOf('.') + 1).ToUpper());
                }

                lvDisplay.Items.Add(token);
            }
        }

        private void lvDisplay_DoubleClick(object sender, EventArgs e)
        {
            if (lvDisplay.SelectedItems[0].Text == "..")
            {
                current_folder = last_folder;
                uri = GetUri(current_folder, "");
                ClearDisplay();
                DisplayDetails(uri);
            }
            else
            {
                last_folder = current_folder;
                current_folder += lvDisplay.SelectedItems[0].Text + "/";
                uri = GetUri(current_folder, "");
                ClearDisplay();
                DisplayDetails(uri);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            uri = GetUri(current_folder, file);
            try
            {
                DisplayDetails(uri);

                btnConnect.Enabled = false;
                btnUpload.Enabled = true;
                btnDownload.Enabled = true;
                btnRefresh.Enabled = true;
                btnGetDate.Enabled = true;
                btnRename.Enabled = true;
                btnGetSize.Enabled = true;
                txtServerIP.ReadOnly = txtUsername.ReadOnly = txtPassword.ReadOnly = true;

                MessageBox.Show("Connect to FTP Server successfully!");
            }
            catch
            {
                MessageBox.Show("Connection failed! Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo fi = new FileInfo(ofd.FileName);
                        file = fi.Name;
                        uri = GetUri(current_folder, file);

                        FtpWebRequest ftp_request = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
                        ftp_request.Credentials = new NetworkCredential(txtUsername.Text, txtPassword.Text);
                        ftp_request.Method = WebRequestMethods.Ftp.UploadFile;
                        ftp_request.ContentLength = fi.Length;

                        byte[] buffer = new byte[buffer_size];
                        FileStream fs = fi.OpenRead();
                        int content_length;
                        Stream ftp_stream = ftp_request.GetRequestStream();
                        do
                        {
                            content_length = fs.Read(buffer, 0, buffer_size);
                            ftp_stream.Write(buffer, 0, content_length);
                            ftp_stream.Flush();
                        } while (content_length != 0);
                        fs.Close();
                        ftp_stream.Close();
                        MessageBox.Show("Upload file successfully!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Uploading failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (lvDisplay.SelectedItems.Count > 0 && lvDisplay.SelectedItems[0].SubItems[3].Text != "Folder")
            {
                try
                {
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        file = lvDisplay.SelectedItems[0].Text;
                        uri = GetUri(current_folder, file);

                        FtpWebRequest ftp_request = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
                        ftp_request.Credentials = new NetworkCredential(txtUsername.Text, txtPassword.Text);
                        ftp_request.Method = WebRequestMethods.Ftp.DownloadFile;

                        sfd.FileName = file;
                        sfd.Filter = "All files | *.*";
                        byte[] buffer = new byte[buffer_size];
                        int content_length;
                        using (FtpWebResponse ftp_response = (FtpWebResponse)ftp_request.GetResponse())
                        {
                            if (sfd.ShowDialog() == DialogResult.OK)
                            {
                                FileStream fs = (FileStream)sfd.OpenFile();
                                Stream ftp_stream = ftp_response.GetResponseStream();
                                do
                                {
                                    content_length = ftp_stream.Read(buffer, 0, buffer_size);
                                    fs.Write(buffer, 0, content_length);
                                    fs.Flush();
                                } while (content_length > 0);
                                fs.Close();
                                ftp_stream.Close();
                                MessageBox.Show("Download file successfully!");
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Downloading failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please choose a file, not a folder!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                ClearDisplay();
                DisplayDetails(uri);
            }
            catch
            {
                MessageBox.Show("Error!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GetFileDateTime()
        {
            try
            {
                uri = GetUri(current_folder, file);

                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(new Uri(uri));
                ftpRequest.Credentials = new NetworkCredential(txtUsername.Text, txtPassword.Text);
                ftpRequest.Method = WebRequestMethods.Ftp.GetDateTimestamp;

                FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                DateTime file_time = ftpResponse.LastModified;
                ftpResponse.Close();
                ftpRequest = null;
                return file_time.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Getting date failed!" + '\n' + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
        }

        public void Rename(string newFileName)
        {
            try
            {
                uri = GetUri(current_folder, file);

                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(new Uri(uri));
                ftpRequest.Credentials = new NetworkCredential(txtUsername.Text, txtPassword.Text);
                ftpRequest.Method = WebRequestMethods.Ftp.Rename;
                ftpRequest.RenameTo = newFileName;

                FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                ftpResponse.Close();
                ftpRequest = null;
                MessageBox.Show("Renaming successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Renaming failed!" + '\n' +ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public long GetFileSize()
        {
            try
            {
                uri = GetUri(current_folder, file);

                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(new Uri(uri));
                ftpRequest.Credentials = new NetworkCredential(txtUsername.Text, txtPassword.Text);
                ftpRequest.Method = WebRequestMethods.Ftp.GetFileSize;

                FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                long size = ftpResponse.ContentLength;
                ftpResponse.Close();
                ftpRequest = null;
                return size;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Getting size failed!" + '\n' + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void btnGetDate_Click(object sender, EventArgs e)
        {
            if (lvDisplay.SelectedItems.Count > 0)
            {
                file = lvDisplay.SelectedItems[0].Text;
                string date = GetFileDateTime();
                MessageBox.Show(date, "Last Modified:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please choose a file/folder", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (lvDisplay.SelectedItems.Count > 0 && txt_New_name.Text != "")
            {
                file = lvDisplay.SelectedItems[0].Text;
                Rename(txt_New_name.Text);
            }
            else
            {
                MessageBox.Show("Please choose a file and type a new name first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGetSize_Click(object sender, EventArgs e)
        {
            if (lvDisplay.SelectedItems.Count > 0)
            {
                file = lvDisplay.SelectedItems[0].Text;
                long file_size = GetFileSize();
                MessageBox.Show(file_size.ToString() + " bytes", "Result:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please choose a file", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}