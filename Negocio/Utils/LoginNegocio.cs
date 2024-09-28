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
        public void Login(string username, string password) 
        {
            //aca escribo que hace el login

            LoginDB loginDB = new LoginDB();
            loginDB.guardarIntento(username);


            LoginWS loginWS = new LoginWS();
            loginWS.login(username, password);




        }
    }
}
