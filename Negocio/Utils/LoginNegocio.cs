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
<<<<<<< HEAD
        public String login(string usuario,string password)
=======
        private int intentos = 0; //Manejamos los intentos desde acá
        public String login(string usuario, string password)
>>>>>>> origin/TomasAlberio
        {
            String perfilLogin = "";
            string nombre = "";

<<<<<<< HEAD
            
            LoginDB loginDB = new LoginDB();
            
            
             // circuito de bloqueado de usuario - faltaaaa
            
           
            LoginWS loginWS = new LoginWS();
            String idUsuario = loginWS.login(usuario, password);

            if(idUsuario != "Error")
            {

                // Paso 2.2: Credenciales invalidas --falta

                // Paso 2.3: Credenciales validas--falta


                List<UsuarioWS> usuariosActivos = loginWS.BuscarDatosUsuario(idUsuario);

                // Paseo 3.1: Verificar que el usuario este activo-- falta


                int perfilUsuarioLogueado = 0;

                foreach (UsuarioWS usuarioActivo in usuariosActivos)
                {
                    if (usuarioActivo.Id.Equals(idUsuario))
                    {
                        perfilUsuarioLogueado = usuarioActivo.Perfil;
                        nombre = usuarioActivo.Nombre;
                    }
                }


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

                return perfilLogin + nombre;
            }
            else
            {
                string errorcontraseña = idUsuario;
                return errorcontraseña;
            }

        }




=======

            LoginDB loginDB = new LoginDB();
            LoginWS loginWS = new LoginWS();

            // Obtener la lista de usuarios activos desde el servicio
            List<UsuarioWS> usuariosActivos = loginWS.buscarDatosUsuario();

            // Verificar si el usuario está en la lista de usuarios activos
            UsuarioWS usuarioActivo = usuariosActivos.FirstOrDefault(u => u.NombreUsuario == usuario);

            if (usuarioActivo == null)
            {
                // El usuario no está en la lista, lo marcamos como inactivo
                return "Usuario no activo"; // Retornar este mensaje si no encontramos el usuario
            }

            // Si el usuario está activo, verificar las credenciales de login
            String idUsuario = loginWS.login(usuario, password);

            if (idUsuario == "Error")
            {
                // Incrementar intentos si las credenciales no son válidas
                intentos++;
                // Manejar intentos fallidos con if-else
                if (intentos < 3)
                {
                    return "Error"; // Si no alcanzamos el límite, retornamos "Error"
                }
                else
                {
                    // Si se llega al tercer intento fallido, consideramos la cuenta bloqueada
                    return "Cuenta bloqueada por intentos fallidos"; // Bloqueamos la cuenta lógicamente
                }
            }

            // Obtener el perfil del usuario logueado
            int perfilUsuarioLogueado = usuarioActivo.Host;
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

>>>>>>> origin/TomasAlberio
    }


}





