using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HamoodMessangerV0._1
{
    public class MyTcpClient
    {
        public void SendMessage(string ip, int port, string message)
        {
            TcpClient client = new TcpClient(ip, port);
            NetworkStream stream = client.GetStream();

            byte[] data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);

            Console.WriteLine("Message sent!");
            client.Close();
        }
    }
}
