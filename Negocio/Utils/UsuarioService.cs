using Datos;
using Persistencia;
using Persistencia.UsuariosData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;
        private readonly UsuarioWS _usuarioWS;

        public UsuarioService()
        {
            _usuarioRepository = new UsuarioRepository();
            _usuarioWS = new UsuarioWS();
        }

        // Método para cambiar la contraseña del usuario
        public bool CambiarContraseñaAsync(string nombreUsuario, string contraseñaActual, string nuevaContraseña)
        {
            // Validar que la nueva contraseña cumpla con ciertas reglas de negocio
            if (string.IsNullOrWhiteSpace(nuevaContraseña))
            {
                throw new ArgumentException("La nueva contraseña no puede estar vacía.");
            }

            if (nuevaContraseña.Length < 8)
            {
                throw new ArgumentException("La nueva contraseña debe tener al menos 8 caracteres.");
            }

            // Si las validaciones pasan, se delega la llamada al repositorio (capa de Datos)
            bool resultado = _usuarioRepository.CambioPassword(nombreUsuario, contraseñaActual, nuevaContraseña);

            return resultado;
        }

        public bool RegistrarUsuario(string host, string nombre, string apellido, int documento, string direccion, string telefono, string email, DateTime fechaNacimiento, string usuario, string contraseña)
        {
            int hostvalor;

            switch (host)
            {
                case "Vendedor (1)":
                    hostvalor = 1;
                    break;
                case "Supervisor (2)":
                    hostvalor = 2;
                    break;
                case "Administrador (3)":
                    hostvalor = 3;
                    break;
                default:
                    hostvalor = 1;
                    break;
            }

            bool response = _usuarioWS.RegistrarUsuario(hostvalor, nombre, apellido, documento, direccion, telefono, email, fechaNacimiento, usuario, contraseña);

            if (!response)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        // Creamos el metodo para Reactivar Usuario
        public bool ReactivarUsuario(string id)
        {

            bool response = _usuarioWS.ReactivarUsuario(id);

            if (!response)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}