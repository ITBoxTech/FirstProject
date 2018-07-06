using System;
using System.Windows.Forms;

using VPN_Connect.Model;

namespace VPN_Connect.Controller
{
    class MessageController
    {
        MessageModel mm = new MessageModel();

        //Message Box Show
        public void alertMsg(string Message)
        {
            MsgBox(GetMsg(Message));
        }

        //Console Show
        public void ConsoleMsg(string Message)
        {
            console(GetMsg(Message));
        }

        //Return Message as string
        public string ReturnMsg(string Message)
        {
            return GetMsg(Message);
        }

        //Get Message From MessageController
        public string GetMsg(string MsgCode)
        {
            try
            {
                int i;
                for (i = 0; i < (mm.InfoMsg.Length / 2); i++)
                {
                    if (mm.InfoMsg[i, 0] == MsgCode)
                    {
                        return mm.InfoMsg[i, 1];
                    }
                }
                return "";
            }
            catch
            {
                return "";
            }
        }

        //Alert message
        public void MsgBox(string msg)
        {
            MessageBox.Show(msg);
        }

        //Console message
        public void console(string msg)
        {
            Console.WriteLine(msg);
        }

        //MessageController Constructor
        public MessageController()
        {

        }
    }
}