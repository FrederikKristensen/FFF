using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FFFApp.model.Persitens
{
    class EventPersitens
    {
        //private string URI = "http://localhost:61270/api/Eventtabs/";
        private string URI = "http://fana-web-app.azurewebsites.net/api/Eventtabs/";

        public async Task<Event> OpretEvent(Event _event)
        {
            using (HttpClient EventClient = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(_event);
                StringContent StrContent = new StringContent(json, Encoding.UTF8, "application/json");

                var res = await EventClient.PostAsync(URI, StrContent);
                if (res.IsSuccessStatusCode)
                {
                    string S = await res.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Event>(S);
                }
            }

            return null;
        }
    }
}
