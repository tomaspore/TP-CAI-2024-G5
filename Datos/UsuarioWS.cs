using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioWS
    {
        public UsuarioWS() { }

        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string NombreUsuario { get; set; }
        public int Host { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Contraseña { get; set; }

        public async Task<bool> RegistrarUsuarioAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://cai-tp.azurewebsites.net");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string jsonData = JsonConvert.SerializeObject(this);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync("/api/Usuario/AgregarUsuario", content);

                    if (!response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Error en la respuesta de la API: " + response.ReasonPhrase);
                    }

                    return response.IsSuccessStatusCode;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en UsuarioWS.RegistrarUsuarioAsync: " + ex.Message);
                    return false;
                }
            }
        }

        // Nuevo método para cambiar la contraseña
        public async Task<bool> CambiarContraseñaAsync(string nombreUsuario, string contraseñaActual, string nuevaContraseña)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://cai-tp.azurewebsites.net");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                // Crear un objeto anónimo con los datos necesarios para el cambio de contraseña
                var data = new
                {
                    NombreUsuario = nombreUsuario,
                    ContraseñaActual = contraseñaActual,
                    NuevaContraseña = nuevaContraseña
                };

                // Serializar el objeto a JSON
                string jsonData = JsonConvert.SerializeObject(data);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Enviar la solicitud POST a la API para cambiar la contraseña
                HttpResponseMessage response = await client.PostAsync("/api/Usuario/CambiarContraseña", content);

                return response.IsSuccessStatusCode;
            }
        }
    }
}