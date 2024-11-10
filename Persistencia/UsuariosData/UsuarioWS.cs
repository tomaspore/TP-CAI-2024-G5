using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Persistencia.UsuariosData
{
    public class UsuarioWS
    {
        // Propiedades del usuario
        private Guid _id;
        private string _nombre;
        private string _apellido;
        private int _dni;
        private string _nombreUsuario;
        private int _host;

        public UsuarioWS(Guid id, string nombre, string apellido, int dni, string nombreUsuario, int host)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            NombreUsuario = nombreUsuario;
            Host = host;
        }

        // Constructor sin parámetros (nuevo)
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

        // Método para obtener usuarios activos
        public async Task<List<Guid>> ObtenerUsuariosActivosAsync()
        {
            List<Guid> listaIds = new List<Guid>();

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://cai-tp.azurewebsites.net"); // URL base de la API
                HttpResponseMessage response = await client.GetAsync("/api/Usuario/TraerUsuariosActivos");

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();
                    List<UsuarioWS> usuarios = JsonConvert.DeserializeObject<List<UsuarioWS>>(jsonContent);

                    foreach (UsuarioWS usuario in usuarios)
                    {
                        listaIds.Add(usuario.Id);
                    }
                }
                else
                {
                    throw new HttpRequestException("Error al obtener los usuarios activos.");
                }
            }
            return listaIds;
        }
        // Método para registrar un nuevo usuario
        public async Task<bool> RegistrarUsuarioAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://cai-tp.azurewebsites.net");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                // Serializar el objeto a JSON
                string jsonData = JsonConvert.SerializeObject(this);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Enviar la solicitud POST
                HttpResponseMessage response = await client.PostAsync("/api/Usuario/AgregarUsuario", content);

                return response.IsSuccessStatusCode;
            }
        }
    }
}