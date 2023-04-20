using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallAPI
{
    public static class Rest_Helper
    {
        private static readonly string baseURL = "https://jsonplaceholder.typicode.com/albums";

        public static async Task<string> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if(data != null)
                        {
                            return data;
                        }    
                    }    
                }    
            }
            return string.Empty;
        }
    }
}
