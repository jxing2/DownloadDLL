using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerClient
{
    class Message
    {
        private StreamReader sr;
        private StreamWriter sw;
        Socket socket;
        public Message(StreamReader sr, StreamWriter sw, Socket socket) {
            this.sr = sr;
            this.sw = sw;
            this.socket = socket;
        }
        public string getMessage() {
            int len = 2;
            char[] chars = getCharByLen(len);
            if (chars[0] == (char)(65533) && chars[1] == (char)(65533) )
            {
                chars = getCharByLen(len); // 将接下来的2个control char读出来扔掉
                chars = getCharByLen(len); // 读取到有用的control char
            }
            switch (chars[0]) {
                case (char)(119):
                    len = chars[1];
                    break;
                case (char)(122):
                    int i4 = chars[1];
                    chars = getCharByLen(3);
                    len = getMessageLengthByChars(i4, chars);
                    break;
                default:
                    throw new Exception("unknown control char : " + chars[0]);
            }
            return new string(getCharByLen(len));
        }
        private static int stage4 = 256*256*256;
        private static int stage3 = 256*256;
        private static int stage2 = 256;
        private int getMessageLengthByChars(int i4, char[] chars)
        {
            int i3 = chars[0];
            int i2 = chars[1];
            int i1 = chars[2];
            return i4 * stage4 + i3 * stage3 + i2 * stage2 + i1;
        }

        private char[] getCharByLen(int len) {
            int realLen = 0;
            char[] chars = new char[len];
            while (len > realLen) {
                int tmpLen = sr.Read(chars, realLen, len - realLen);
                if (tmpLen == -1 && len > realLen) {
                    throw new Exception("bad message");
                }
                realLen += tmpLen;
            }
            return chars;
        }

        internal void sendMessage(short x1, short x2)
        {
            byte[] bytes = new byte[8];

            bytes[0] = 172;//0xac;
            bytes[1] = 237;//0xed;
            bytes[2] = 0;
            bytes[3] = 5;

            //bytes[0] = 0xed;
            //bytes[1] = 0xac;
            //bytes[2] = 0x5;
            //bytes[3] = 0x0;
            socket.Send(bytes);
            //sendMessage(System.Text.Encoding.Default.GetString(bytes));
            //System.Text.Encoding.Default.GetString(bytes)
            //byte[] buffer = Encoding.UTF8.GetBytes(message);
            //clientSocket.Send(buffer);
        }

        public bool sendMessage(string msg) {
            try
            {
                if (msg.Length < 256)
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(msg.ToCharArray());
                    byte[] newBytes = new byte[bytes.Length + 2];
                    newBytes[0] = 119;
                    newBytes[1] = (byte)bytes.Length;
                    bytes.CopyTo(newBytes, 3);
                    socket.Send(newBytes);
                    //char[] buffer = msg.ToCharArray();
                    //char[] newBuf = new char[buffer.Length + 2];
                    //newBuf[0] = 'w';
                    //newBuf[1] = (char)buffer.Length;
                    //buffer.CopyTo(newBuf, 2);
                    //sw.Write(new string(newBuf));
                    //sw.Flush();
                }
                else if (msg.Length >= 256) {
                    sw.Write(msg);
                    sw.Flush();
                }
                
            }
            catch {
                return false;
            }
            return true;
        }
    }
}
