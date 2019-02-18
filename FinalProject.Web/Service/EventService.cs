using FinalProject.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;

namespace FinalProject.Web.Service
{
    public static class EventService
    {
        public static async Task<List<EventModel>> Get()
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri("http://localhost:57865/api/Events");

                var json = await client.GetStringAsync(uri);
                var result = JsonConvert.DeserializeObject<List<EventModel>>(json);

                return result;
            }
        }
    }
}