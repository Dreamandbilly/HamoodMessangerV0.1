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

        public event Action<string, string> OnMessageReceived;
        public event Action<string, string> OnImageReceived;

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
            {
                try
                {
                    byte[] headerBytes = new byte[20];
                    int headerRead = 0;
                    while (headerRead < headerBytes.Length)
                    {
                        int r = await stream.ReadAsync(headerBytes, headerRead, headerBytes.Length - headerRead);
                        if (r == 0) return;
                        headerRead += r;
                    }

                    string header = Encoding.UTF8.GetString(headerBytes).Trim();
                    string[] parts = header.Split('|');
                    if (parts.Length != 2) return;

                    string type = parts[0];
                    if (!int.TryParse(parts[1], out int length)) return;

                    byte[] buffer = new byte[length];
                    int totalRead = 0;
                    while (totalRead < length)
                    {
                        int read = await stream.ReadAsync(buffer, totalRead, length - totalRead);
                        if (read == 0) break;
                        totalRead += read;
                    }

                    if (type == "TXT")
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, totalRead);
                        OnMessageReceived?.Invoke(senderIp, message);
                    }
                    else if (type == "IMG")
                    {
                        string folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ReceivedImages");
                        Directory.CreateDirectory(folder);
                        string filePath = Path.Combine(folder, $"IMG_{DateTime.Now:yyyyMMdd_HHmmssfff}.jpg");
                        File.WriteAllBytes(filePath, buffer);
                        OnImageReceived?.Invoke(senderIp, filePath);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Receive error: " + ex.Message);
                }
            }
        }

        public async Task SendMessageAsync(string ip, int port, string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            await SendPacketAsync(ip, port, "TXT", data);
        }

        public async Task SendImageAsync(string ip, int port, string filePath)
        {
            byte[] data = File.ReadAllBytes(filePath);
            await SendPacketAsync(ip, port, "IMG", data);
        }

        private async Task SendPacketAsync(string ip, int port, string type, byte[] data)
        {
            try
            {
                using var client = new TcpClient();
                await client.ConnectAsync(IPAddress.Parse(ip), port);

                using var stream = client.GetStream();
                string header = $"{type}|{data.Length}";
                byte[] headerBytes = Encoding.UTF8.GetBytes(header.PadRight(20));

                await stream.WriteAsync(headerBytes, 0, headerBytes.Length);
                await stream.WriteAsync(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Send {type} failed: {ex.Message}");
            }
        }
    }
}
