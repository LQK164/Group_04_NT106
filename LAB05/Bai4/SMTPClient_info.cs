namespace Bai4
{
    internal class SMTP_Client_Info
    {
        private string SMTPHost;
        private int SMTPPort;
        private string Username;
        private string Password;

        public SMTP_Client_Info()
        {
            this.SMTPHost = "";
            this.SMTPPort = 0;
            this.Username = "";
            this.Password = "";
        }

        public SMTP_Client_Info(string Host, int Port, string Username, string Password)
        {
            this.SMTPHost = Host;
            this.SMTPPort = Port;
            this.Username = Username;
            this.Password = Password;
        }

        public string Get_Host()
        {
            return this.SMTPHost;
        }

        public int Get_Port()
        {
            return this.SMTPPort;
        }

        public string Get_Name()
        {
            return this.Username;
        }

        public string Get_Pass()
        {
            return this.Password;
        }
    }
}