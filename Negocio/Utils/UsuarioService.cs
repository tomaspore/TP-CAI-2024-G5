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

        public async Task<bool> RegistrarUsuario(Guid id, string nombre, string apellido, int dni, string nombreUsuario, int host, string direccion, string telefono, string email, DateTime fechaNacimiento, DateTime fechaAlta, string contraseña)
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

            return await nuevoUsuario.RegistrarUsuarioAsync();
        }
    }
}