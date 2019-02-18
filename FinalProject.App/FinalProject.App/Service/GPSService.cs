using FinalProject.App.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.App.Service
{
    public static class GPSService
    {
        public static async Task<string> Get(string adresse)
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri("http://dev.virtualearth.net/REST/v1/Locations?q=" + adresse.Replace(" ",string.Empty) + "&output=json&key=AiVtyKOfbie_p8qxC80wd3CXFWEANbXN_zSJcx9FdCV746v6At4qD-i-qjMWBhXU");

                var json = await client.GetStringAsync(uri);
                var result = JsonConvert.DeserializeObject<RootObject>(json);

                return result.resourceSets[0].resources[0].point.coordinates[0].ToString() + " " 
                    + result.resourceSets[0].resources[0].point.coordinates[1].ToString();
            }
        }
        
    }
}
