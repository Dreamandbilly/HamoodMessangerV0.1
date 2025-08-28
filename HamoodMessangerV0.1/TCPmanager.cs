using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HamoodMessangerV0._1
{


    public class TCPManager
    {
        private TcpListener _listener;
        private bool _running;

        // senderIp, message
        public event Action<string, string> OnMessageReceived;

        public void StartServer(int port)
        {
            _listener = new TcpListener(IPAddress.Any, port);
            _listener.Start();
            _running = true;

            Task.Run(async () =>
            {
                while (_running)
                {
                    var client = await _listener.AcceptTcpClientAsync();
                    _ = Task.Run(() => HandleClient(client));
                }
            });
        }

        public void StopServer()
        {
            _running = false;
            try { _listener?.Stop(); } catch { }
        }

        private async Task HandleClient(TcpClient client)
        {
            string senderIp = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
            using (client)
            using (var stream = client.GetStream())
            using (var reader = new StreamReader(stream, Encoding.UTF8, leaveOpen: false))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    OnMessageReceived?.Invoke(senderIp, line);
                }
            }
        }

        public async Task SendMessageAsync(string ip, int port, string message)
        {
            try
            {
                using var client = new TcpClient();
                await client.ConnectAsync(IPAddress.Parse(ip), port);
                using var stream = client.GetStream();
                using var writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true };
                await writer.WriteLineAsync(message);
            }
            catch (Exception ex)
            {
                // log or show an error if you want
                Console.WriteLine("Send failed: " + ex.Message);
            }
        }
    }
}