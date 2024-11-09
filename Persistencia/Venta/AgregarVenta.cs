using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Venta
{

    public class AgregarVenta
    { 
        public bool AgregarVentaCliente(string idCliente, string idUsuario, string idProducto, int cantidad)
        {
            // Crear el diccionario con los parámetros del producto
            Dictionary<String, Object> datos = new Dictionary<String, Object>
                {
                    { "idCliente", idCliente },
                    { "idUsuario", idUsuario },
                    { "idProducto", idProducto },
                    { "cantidad", cantidad }

                };

            try
            {
                // Convertir el objeto cliente a una cadena JSON
                var jsonData = JsonConvert.SerializeObject(datos);

                // Enviar la solicitud POST
                HttpResponseMessage response = WebHelper.Post("Venta/AgregarVenta", jsonData);


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
