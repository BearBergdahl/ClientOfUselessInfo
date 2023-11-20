using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClientOfUselessInfo
{
    
    internal static class ClientService
    {
        private static HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            return client;
        }

        internal static async Task<HttpResponseMessage> GetData(string path)
        {
            using (HttpClient client = GetHttpClient())
            {
                return await client.GetAsync(path);
            }            
        }  
    }
}
