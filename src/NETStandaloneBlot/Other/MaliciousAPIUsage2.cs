using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace NETStandaloneBlot.Other
{
    class MaliciousAPIUsage2
    {
        public void Run()
        {
            // CTSECISSUE: MaliciousAPIUsage
            TcpClient client = new TcpClient("", 13000);
            NetworkStream stream = client.GetStream();

            // CTSECISSUE: MaliciousAPIUsage
            UdpClient udpClient = new UdpClient();
            udpClient.Connect("", 10000);

            // CTSECISSUE: MaliciousAPIUsage
            TcpListener server = new TcpListener(new IPAddress(124300), 10002);
            server.Start();

            IPEndPoint ipe = new IPEndPoint(273622, 123123);
            // CTSECISSUE: MaliciousAPIUsage
            Socket tempSocket =
                new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            tempSocket.Connect(ipe);
        }
    }
}
