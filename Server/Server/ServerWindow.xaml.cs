﻿using Server.ScreenGrabber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using Server.Utils;
using Server.Network;
using ProtoBuf;

namespace Server
{
    public partial class ServerWindow : Window
    {
        public ServerWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GenerateProto()
        {
            string proto = Serializer.GetProto<LdpPacket>();
            //File.WriteAllText("Protocol\\messages.proto", proto);
        }

       
    }
}
