using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class Proveedores
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<List<Proveedor>> ObtenerProveedoresAsync()
        {
            HttpResponseMessage response = WebHelper.Get("Proveedor/TraerProveedores");
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                List<Proveedor> proveedores = JsonConvert.DeserializeObject<List<Proveedor>>(responseBody);
                return proveedores;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                return new List<Proveedor>();
            }
        }
    }

    public class Proveedor
    {
        public string Id { get; set; }  // Cambia el tipo de 'int' a 'string'
        public string Nombre { get; set; }
        // Otros campos según tu modelo
    }
}