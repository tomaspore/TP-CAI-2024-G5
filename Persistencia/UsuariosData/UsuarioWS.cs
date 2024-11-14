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
        public bool RegistrarUsuario(int hostvalor, string nombre, string apellido, int documento, string direccion, string telefono, string email, DateTime fechaNacimiento, string usuario, string contraseña)
        {
            string idUsuario = "1653c7ec-870d-468a-b581-9800961d53d2";
            // Crear el diccionario con los parámetros del producto
            Dictionary<String, Object> datos = new Dictionary<String, Object>
      {
          { "idUsuario", idUsuario },
          { "host", hostvalor },
          {"nombre",nombre },
          { "apellido", apellido },
          { "dni", documento },
          { "direccion", direccion },
          { "telefono", telefono },
          {"email",email },
          {"fechaNacimiento",fechaNacimiento },
          {"nombreUsuario",usuario },
          {"contraseña",contraseña }

      };

            try
            {
                // Convertir el objeto cliente a una cadena JSON
                var jsonData = JsonConvert.SerializeObject(datos);

                // Enviar la solicitud POST
                HttpResponseMessage response = WebHelper.Post("Usuario/AgregarUsuario", jsonData);


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
        public bool ReactivarUsuario(string idUsuario)
        {
            string idAdmin = "1653c7ec-870d-468a-b581-9800961d53d2";
            //El idadmin para poder tener permisos.

            try
            {
                Dictionary<String, Object> datos = new Dictionary<String, Object>
                {
                { "id", idUsuario },
                { "idUsuario", idAdmin },
                };

                var jsonData = JsonConvert.SerializeObject(datos);
                HttpResponseMessage response = WebHelper.Patch("Usuario/ReactivarUsuario", jsonData);


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
        public bool BajaUsuario(string idUsuario)
        {
            string idAdmin = "1653c7ec-870d-468a-b581-9800961d53d2";
            //El idadmin para poder tener permisos.

            Dictionary<String, Object> datos = new Dictionary<String, Object>
            {
                { "id", idUsuario },
                { "idUsuario", idAdmin },

            };
            var jsonData = JsonConvert.SerializeObject(datos);
            HttpResponseMessage response = WebHelper.DeleteWithBody("Usuario/BajaUsuario", jsonData);


            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                return false;
            }

            return true;

        }


    }
}