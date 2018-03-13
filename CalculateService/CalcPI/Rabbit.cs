using DAL;
using EasyNetQ;
using EasyNetQ.NonGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalcPI
{
    public class Rabbit
    {

        public void GetFromRabbit()
        {
            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                bus.Subscribe<PImodel>("Presentation", HandleTextMessage);
            }
        }

        private void HandleTextMessage(PImodel obj)
        {
            SendToRabbit(obj.piValue);
        }


        public void SendToRabbit(int value)
        {
            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                var pi = new PImodel { piValue = value };
                bus.Send("CalculatedReplyQueue", pi);
            }
        }

    }
}