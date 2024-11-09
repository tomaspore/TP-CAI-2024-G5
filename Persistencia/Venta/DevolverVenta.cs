using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Venta
{
    public class DevolverVentaWS
    {
        public bool DevolverVenta(string idVenta)
        {
            string idUsuario = "2e4fd5c6-ab32-4661-8a12-1b79035d4e4b";
            //La devolución siempre se ve con el mismo perfil

            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("id", idVenta);
            data.Add("idUsuario", idUsuario);

            try
            {
                var jsonData = JsonConvert.SerializeObject(data);
                Console.WriteLine($"Datos JSON enviados: {jsonData}");

                HttpResponseMessage response = WebHelper.Patch("Venta/DevolverVenta", jsonData);
                Console.WriteLine($"Código de estado de la respuesta: {response.StatusCode}");

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    // Imprimir el contenido de la respuesta en caso de error
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine($"Contenido de la respuesta: {contentStream}");
                }

                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error de solicitud HTTP: {e.Message}");
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error inesperado: {e.Message}");
                return false;
            }

        }

    }
}
