using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Bai4
{
    // Description   -> |dataIdentifier|username length|message length|    username   |    message   |
    // Size in bytes -> |       4      |     4         |       4      |username length|message length|

    public enum DataIdentifier
    {
        LogIn,
        LogOut,
        Message,
        File,
        Null
    }

    public class Packet
    {
        private DataIdentifier dataIdentifier;
        private string username;
        private string message;

        public DataIdentifier ChatDataIdentifier
        {
            get { return dataIdentifier; }
            set { dataIdentifier = value; }
        }

        public string ChatName
        {
            get { return username; }
            set { username = value; }
        }

        public string ChatMessage
        {
            get { return message; }
            set { message = value; }
        }

        public Packet()
        {
            this.dataIdentifier = DataIdentifier.Null;
            this.username = "";
            this.message = "";
        }

        public Packet(byte[] data)
        {
            // Read the dataIdentifier from the beginning (4 bytes)
            this.dataIdentifier = (DataIdentifier)BitConverter.ToInt32(data, 0);

            // Read the length of username (4 bytes)
            int username_length = BitConverter.ToInt32(data, 4);

            // Read the length of message (4 bytes)
            int message_length = BitConverter.ToInt32(data, 8);

            // Read the username field
            if (username_length > 0)
            {
                this.username = Encoding.UTF8.GetString(data, 12, username_length);
            }
            else
            {
                this.username = "";
            }

            // Read the message field
            if (message_length > 0)
            {
                this.message = Encoding.UTF8.GetString(data, 12 + username_length, message_length);
            }
            else
            {
                this.message = "";
            }
        }

        // Convert packet into array of bytes
        public byte[] GetDataStream()
        {
            List<byte> data = new List<byte>();

            // Add dataIdentifier
            data.AddRange(BitConverter.GetBytes((int)this.dataIdentifier));

            // Add the length of username
            if (this.username != "")
            {
                data.AddRange(BitConverter.GetBytes(this.username.Length));
            }
            else
            {
                data.AddRange(BitConverter.GetBytes(0));
            }

            // Add the length of message
            if (this.message != "")
            {
                data.AddRange(BitConverter.GetBytes(this.message.Length));
            }
            else
            {
                data.AddRange(BitConverter.GetBytes(0));
            }

            // Add username
            if (this.username != "")
            {
                data.AddRange(Encoding.UTF8.GetBytes(this.username));
            }

            // Add message
            if (this.message != "")
            {
                data.AddRange(Encoding.UTF8.GetBytes(this.message));
            }

            // return array of bytes
            return data.ToArray();
        }
    }
}