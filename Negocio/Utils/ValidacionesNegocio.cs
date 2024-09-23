using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ValidacionesNegocio
    {
        public bool ValidarNombreUsuario(string username)
        {
            if (username.Length < 8)
            {
                return true;
            }

            return false;
        }


        // Creamos una validación para que el nombre de usuario contenga entre 8 y 15 caracteres
        public bool ValidarNombreRegistroUsuario(string usuario, string nombre, string apellido, out string error)
        {
            error = "";

            // if para ver si el usuario tiene entre 8 y 15 caracteres
            if(usuario.Length < 8 || usuario.Length > 15)
            {
                error = "El usuario tiene que tener entre 8 y 15 caracteres.";
                return false;
            }

            // Si el usuario ingresado contiene entre 8 y 15 caracteres, ok validacion
            return true;
        }

    }
}
