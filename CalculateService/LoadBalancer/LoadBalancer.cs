using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcPI;
using Eneter.Messaging.MessagingSystems.MessagingSystemBase;
using Eneter.Messaging.MessagingSystems.TcpMessagingSystem;
using Eneter.Messaging.Nodes.LoadBalancer;

namespace LoadBalancer
{
    class LoadBalancer : ICalcService
    {
        IMessagingSystemFactory messageCreator;
        ILoadBalancer RRLoadBalancer;
        IDuplexInputChannel input;

        public LoadBalancer(string value)
        {
            messageCreator = new TcpMessagingSystemFactory();

            RRLoadBalancer = new RoundRobinBalancerFactory(messageCreator).CreateLoadBalancer();

            foreach (string ipaddress in GetServiceIPs())
            {
                RRLoadBalancer.AddDuplexOutputChannel(ipaddress);
            }

            input = messageCreator.CreateDuplexInputChannel("tcp://127.0.0.1:65000");

            RRLoadBalancer.AttachDuplexInputChannel(input); 
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }

        public decimal PI(string value)
        {
            
        }

        public int Prime(string value)
        {
            throw new NotImplementedException();
        }

        private string[] GetServiceIPs()
        {
            return new string[] {"tcp://127.0.0.1:65001", "tcp://127.0.0.1:65002", "tcp://127.0.0.1:65003"};
        }
    }
}
