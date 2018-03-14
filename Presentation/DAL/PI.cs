using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace DAL
{
    public class PI : Client
    {

        //public Task<HttpResponseMessage> GetPIAsync(string value)
        //{
        //    client = new HttpClient();
        //    HttpResponseMessage response = client.GetAsync(_url + "/pi/"+value).Result;
        //    var content = response.Content.ReadAsAsync<>().Result;

        //    return ;

        //}

        //public HttpResponseMessage GetPrime(string value)
        //{
        //    client = GetHttpClient();
        //    HttpResponseMessage response = client.GetAsync(_url + "/prime/" + value).Result;
        //    return response;
        //}

        public void SendToRabbit(string value)
        {

            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                bus.Publish(new PImodel
                {
                    piValue = Convert.ToInt16(value)
                });

            }

        }

        public void GetFromRabbit()
        {
            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                bus.Receive("CalculatedReplyQueue", (msg)=>
                {

                });
            };
        }

        private void HandleTextMessage(PImodel obj)
        {
             Convert.ToInt16(obj.piValue).ToString();
        }
    }
}