using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading.Tasks;

namespace BrettspielClient
{
    public class ServerConnector
    {
        public TcpClient Connection;
        public bool Running;

        public ServerConnector(IPEndPoint serverAddress)
        {
            Connection = new TcpClient(serverAddress);
            Running = true;
            Task.Run(()=>EventTrigger());
        }

        public void SendMessage(string message)
        {
            NetworkStream s = Connection.GetStream();
            using (StreamWriter sw = new StreamWriter(s))
            {
                sw.WriteLine(message);
            }
        }

        public void EventTrigger()
        {
            while (Running)
            {

            }
        }
        




    }
}
