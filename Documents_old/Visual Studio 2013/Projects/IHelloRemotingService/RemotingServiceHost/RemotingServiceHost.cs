﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
namespace RemotingServiceHost
{
    class RemotingServiceHost
    {
        static void Main()
        {
            HelloRemotingService.HelloRemotingService remotingserice = new 
                HelloRemotingService.HelloRemotingService();
            TcpChannel channel = new TcpChannel(8080);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(HelloRemotingService.HelloRemotingService), "GetMessage1", WellKnownObjectMode.Singleton);
            Console.WriteLine("Host Started@"+DateTime.Now.ToString());
            Console.ReadLine();



        }
    }
}