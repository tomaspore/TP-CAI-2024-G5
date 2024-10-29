﻿using Datos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class LoginWS
    {
        private String adminId = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public String login(String username, String password)
        {
            Dictionary<String, String> datos = new Dictionary<String, String>();
            datos.Add("nombreUsuario", username);
            datos.Add("contraseña", password);

            
            var jsonData = JsonConvert.SerializeObject(datos);

            HttpResponseMessage response = WebHelper.Post("Usuario/Login", jsonData);

            String idUsuario = "";

            if (response.IsSuccessStatusCode)
            {
                var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                idUsuario = JsonConvert.DeserializeObject<String>(reader.ReadToEnd());
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al momento del Login");
            }

            return idUsuario;
        }

        private List<UsuarioWS> BuscarDatosUsuario(String idUsuario)
        {
            List<UsuarioWS> clientes = new List<UsuarioWS>();

            HttpResponseMessage response = WebHelper.Get("Usuario/TraerUsuariosActivos?id=" + adminId);

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<UsuarioWS> listadoClientes = JsonConvert.DeserializeObject<List<UsuarioWS>>(contentStream);
                return listadoClientes;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                throw new Exception("Error al momento de buscar los usuarios");
            }

        }

        public List<UsuarioWS> BuscarDatosUsuario()
        {
            List<UsuarioWS> clientes = new List<UsuarioWS>();

            HttpResponseMessage response = WebHelper.Get("Usuario/TraerUsuariosActivos?id=" + adminId);

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<UsuarioWS> listadoClientes = JsonConvert.DeserializeObject<List<UsuarioWS>>(contentStream);
            
            }
            List<UsuarioWS> ListadoClientes = null;
            return ListadoClientes; //NO HACE NADA
        }
    }
}
