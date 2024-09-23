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
        // Creamos validación para que el nombre de usuario no pueda contener ni el nombre ni el apellido del usuario
        public bool ValidarNombreRegistroUsuario(string usuario, string nombre, string apellido, out string error)
        {
            error = "";

            // if para ver si el usuario tiene entre 8 y 15 caracteres
            if(usuario.Length < 8 || usuario.Length > 15)
            {
                error = "El usuario tiene que tener entre 8 y 15 caracteres.";
                return false;
            }


            /*
            Antes de crear una validacion para que el nombre de usuario no contenga el nombre ni el apellido
            convertimos los valores que se ingresen a minuscula
            */

            string usuarioL = usuario.ToLower();
            string nombreL = nombre.ToLower();
            string apellidoL = apellido.ToLower();

            // Ahora verificamos con los siguientes if que el nombre de usuario no contenga el nombre ni el apellido
            if(usuarioL.Contains(nombreL) && usuarioL.Contains(apellidoL))
            {
                error = "El usuario no debe contener ni el nombre ni el apellido.";
                return false;
            }

            if(usuarioL.Contains(nombreL) || usuarioL.Contains(apellidoL))
            {
                error = "El usuario esta conteniendo un nombre o apellido.";
                return false;
            }



            /* 
            Si el usuario ingresado contiene entre 8 y 15 caracteres y además
            el usuario no contiene el nombre ni el apellido, ahi entonces
            ok validacion
            */
            return true;
        }

    }
}
