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

        public async Task<HttpResponseMessage> GetPIAsync()
        {
            HttpClient client = GetHttpClient();
            HttpResponseMessage response = await client.GetStringAsync("/pi/5").Result;
            return response;
        }

    }
}