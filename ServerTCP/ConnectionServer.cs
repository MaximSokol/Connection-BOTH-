using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerTCP
{
    class ConnectionServer
    {
        public ConnectionServer() { }
        //------------------------------

        const string ip = "127.0.0.1";
        const int port = 8081;
        //------------------------------

        public void StartConnectionServerTCP()
        {
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpSocket.Bind(tcpEndPoint);
            tcpSocket.Listen(5);

            while (true)
            {
                var listener = tcpSocket.Accept();
                var buffer = new byte[256];
                var size = 0;
                var data = new StringBuilder();

                do
                {
                    size = listener.Receive(buffer);
                    data.Append(Encoding.UTF8.GetString(buffer, 0, size));
                }
                while (listener.Available > 0);

                Console.WriteLine(data); // TODO: проверить .ToString

                listener.Send(Encoding.UTF8.GetBytes("Успех"));

                listener.Shutdown(SocketShutdown.Both);
                listener.Close();
            }
        }
        //--------------------------------------------------------
    }
}
