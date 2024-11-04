using System;
using System.Threading.Tasks;


namespace Datos
{
    public class UsuarioData
    {
        public async Task<bool> RegistrarUsuario(Guid id, string nombre, string apellido, int dni, string nombreUsuario, int host, string direccion, string telefono, string email, DateTime fechaNacimiento, DateTime fechaAlta, string contraseña)
        {
            try
            {
                UsuarioWS nuevoUsuario = new UsuarioWS
                {
                    Id = id,
                    Nombre = nombre,
                    Apellido = apellido,
                    Dni = dni,
                    NombreUsuario = nombreUsuario,
                    Host = host,
                    Direccion = direccion,
                    Telefono = telefono,
                    Email = email,
                    FechaNacimiento = fechaNacimiento,
                    FechaAlta = fechaAlta,
                    Contraseña = contraseña
                };

                // Llamar a la API para registrar el usuario
                bool resultado = await nuevoUsuario.RegistrarUsuarioAsync();

                if (!resultado)
                {
                    Console.WriteLine("Error: No se pudo registrar el usuario en la API.");
                }

                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en UsuarioData.RegistrarUsuario: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> CambiarContraseña(string nombreUsuario, string contraseñaActual, string nuevaContraseña)
        {
            UsuarioWS usuario = new UsuarioWS();
            return await usuario.CambiarContraseñaAsync(nombreUsuario, contraseñaActual, nuevaContraseña);
        }
    }
}

