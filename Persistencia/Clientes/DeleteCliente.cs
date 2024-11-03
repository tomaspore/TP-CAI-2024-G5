using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Clientes
{
    public class DeleteCliente
    {
        private static readonly HttpClient client = new HttpClient();

        public bool BajaCliente(string idCliente)
        {
            HttpResponseMessage response = WebHelper.Delete("Cliente/BajaCliente" + idCliente );

            if(!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                return false;
            }
            
                return true;
          
        }
    }
}
