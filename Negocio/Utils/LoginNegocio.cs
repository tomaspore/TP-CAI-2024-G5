using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LoginNegocio
    {
        private int intentos = 0; //Manejamos los intentos desde acá
        public String login(string usuario, string password)
        {
            String perfilLogin = "";
            string nombre = "";


            LoginDB loginDB = new LoginDB();
            LoginWS loginWS = new LoginWS();

            // Obtener la lista de usuarios activos desde el servicio
            List<UsuarioWS> usuariosActivos = loginWS.buscarDatosUsuario();
            Console.WriteLine("Usuarios Activos encontrados: " + usuariosActivos.Count); // Depuración

            // Verificar si el usuario está en la lista de usuarios activos
            UsuarioWS usuarioActivo = usuariosActivos.FirstOrDefault(u => u.NombreUsuario == usuario);

            if (usuarioActivo == null)
            {
                // El usuario no está en la lista, lo marcamos como inactivo
                Console.WriteLine("Usuario no encontrado o inactivo.");
                return "Usuario no activo"; // Retornar este mensaje si no encontramos el usuario
            }

            // Si el usuario está activo, verificar las credenciales de login
            String idUsuario = loginWS.login(usuario, password);

            if (idUsuario == "Error")
            {
                // Incrementar intentos si las credenciales no son válidas
                intentos++;
                if (intentos == 3)
                {
                    // Si se llega al tercer intento fallido, bloquear al usuario
                    loginWS.bloquearUsuario(usuario);
                    return "Inactivo"; // Retornamos "Inactivo" si el usuario fue bloqueado
                }
                return "Error";
            }

            // Obtener el perfil del usuario logueado
            int perfilUsuarioLogueado = usuarioActivo.Perfil;
            nombre = usuarioActivo.Nombre;

            // Asignar el perfil según el valor del perfilUsuarioLogueado
            if (perfilUsuarioLogueado == 3)
            {
                perfilLogin = "Administrador";
            }
            else if (perfilUsuarioLogueado == 2)
            {
                perfilLogin = "Supervisor";
            }
            else
            {
                perfilLogin = "Vendedor";
            }

            // Reiniciar los intentos si el login es exitoso
            intentos = 0;

            // Retornar el perfil y el nombre del usuario
            return perfilLogin + " " + nombre;
        }

    }
}





