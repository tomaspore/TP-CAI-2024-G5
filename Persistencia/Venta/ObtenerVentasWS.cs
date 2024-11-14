using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Venta
{
    public class ObtenerVentasWS
    {
        public List<Venta> ObtenerVentasPorCliente(Guid idCliente)
        {
            try
            {
                // Realiza la solicitud GET a la API con el ID del cliente
                HttpResponseMessage response = WebHelper.Get($"Venta/GetVentaByCliente?id={idCliente}");

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return null;
                }

                // Leer el contenido de la respuesta de la API
                var contentStream = response.Content.ReadAsStringAsync().Result;

                if (string.IsNullOrEmpty(contentStream))
                {
                    Console.WriteLine("El contenido de la respuesta está vacío.");
                    return null;
                }

                // Deserializar la respuesta en una lista de ventas
                List<Venta> listadoVentas = JsonConvert.DeserializeObject<List<Venta>>(contentStream);

                return listadoVentas;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción: {ex.Message}");
                return null;
            }
        }
    }
}
