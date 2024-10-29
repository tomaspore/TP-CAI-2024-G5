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
        public String login(String usuario, String password)
        {
            String perfilLogin = "";

            
            LoginDB loginDB = new LoginDB();
            

      
            
             // circuito de bloqueado de usuario - faltaaaa
            

           
            LoginWS loginWS = new LoginWS();
            String idUsuario = loginWS.login(usuario, password);

            
            verificarPrimerLogin(usuario);

            // Paso 2.2: Credenciales invalidas --falta

            // Paso 2.3: Credenciales validas--falta

            
            List<UsuarioWS> usuariosActivos = loginWS.BuscarDatosUsuario();

            // Paseo 3.1: Verificar que el usuario este activo-- falta

           
            int perfilUsuarioLogueado = 0;

            foreach (UsuarioWS usuarioActivo in usuariosActivos)
            {
                if (usuarioActivo.Id.Equals(idUsuario))
                {
                    perfilUsuarioLogueado = usuarioActivo.Perfil;
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

            return perfilLogin;
        }

        private void verificarPrimerLogin(string usuario)
        {
            
        }
    }

}
