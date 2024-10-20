using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Persistencia
{
    internal class ModificacionWS
    {
    }

    public class UsuarioRepository 
    {
        private readonly HttpClient _httpClient;

        public UsuarioRepository()
        {
            _httpClient = new HttpClient();
        }

        public async Task<bool> CambiarContraseñaAsync(string nombreUsuario, string contraseña, string contraseñaNueva)
        {
            var url = "https://cai-tp.azurewebsites.net/api/Usuario/CambiarContraseña";

            // Crear el objeto con los datos del cambio de contraseña
            var requestData = new
            {
                nombreUsuario = nombreUsuario,
                contraseña = contraseña,
                contraseñaNueva = contraseñaNueva
            };

            // Convertir el objeto a JSON
            var json = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Realizar la llamada POST
            var response = await _httpClient.PostAsync(url, content);

            // Verificar si la respuesta fue exitosa
            return response.IsSuccessStatusCode;
        }
    }

}
