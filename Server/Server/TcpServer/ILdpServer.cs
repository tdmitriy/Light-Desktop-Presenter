﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server.TcpServer
{
    interface ILdpServer : ILdpServerHandlers
    {
        void Start(int port);
        void Start();
        void Stop();
        void Restart();

        int GetServerPort { get; }
        string GetServerIPAddress { get; }
        string GetClientIPAddress { get; }
        
    }
}
