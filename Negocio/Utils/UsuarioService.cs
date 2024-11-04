using Datos;
using Persistencia;
using System;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;
        private readonly UsuarioData _usuarioData;

        public UsuarioService()
        {
            _usuarioRepository = new UsuarioRepository();
            _usuarioData = new UsuarioData();
        }

        public async Task<bool> RegistrarUsuario(Guid id, string nombre, string apellido, int dni, string nombreUsuario, int host, string direccion, string telefono, string email, DateTime fechaNacimiento, DateTime fechaAlta, string contraseña)
        {
            try
            {
                // Intentar registrar el usuario y devolver el resultado
                bool resultado = await _usuarioData.RegistrarUsuario(id, nombre, apellido, dni, nombreUsuario, host, direccion, telefono, email, fechaNacimiento, fechaAlta, contraseña);

                if (!resultado)
                {
                    Console.WriteLine("Error: No se pudo registrar el usuario en la API.");
                }

                return resultado;
            }
            catch (Exception ex)
            {
                // Capturar y mostrar cualquier excepción que ocurra
                Console.WriteLine("Error en RegistrarUsuario: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> CambiarContraseña(string nombreUsuario, string contraseñaActual, string nuevaContraseña)
        {
            return await _usuarioData.CambiarContraseña(nombreUsuario, contraseñaActual, nuevaContraseña);
        }
    }
}