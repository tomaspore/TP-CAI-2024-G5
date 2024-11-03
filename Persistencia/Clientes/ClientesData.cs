﻿using Datos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Clientes
{

    public class ClientesData
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

    public class DeleteCliente
    {
        private static readonly HttpClient client = new HttpClient();

        public bool BajaCliente(string idCliente)
        {
            HttpResponseMessage response = WebHelper.Delete("Cliente/BajaCliente?id=" + idCliente);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                return false;
            }

            return true;

        }
    }

    public class ActualizarCliente
    {
        private static readonly HttpClient client = new HttpClient();

       
    }
}
