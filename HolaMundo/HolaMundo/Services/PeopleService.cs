using System;
using System.Net.Http;
using System.Threading.Tasks;
using HolaMundo.Model;
using Newtonsoft.Json;

namespace HolaMundo.Services
{
    public class PeopleService
    {
        private HttpClient cliente;

        public PeopleService()
        {
            cliente = new HttpClient();
        }

        public async Task<People> GetPeople(string id)
        {
            string result = await cliente.GetStringAsync(new Uri("https://swapi.dev/api/people/" + id + "/"));

            return JsonConvert.DeserializeObject<People>(result);
        }
    }
}
