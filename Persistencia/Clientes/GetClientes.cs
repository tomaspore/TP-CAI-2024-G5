using Datos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Clientes
{
    public class GetClientes
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<List<ClientesWS>> ListadoClientes()
        {
            HttpResponseMessage response = WebHelper.Get("Cliente/GetClientes");
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                List<ClientesWS> clientes = JsonConvert.DeserializeObject<List<ClientesWS>>(responseBody);
                return clientes;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                return new List<ClientesWS>();
            }

        }
    }
}
