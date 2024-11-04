using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


        /*
        Creamos validación para que:
        -	La contraseña tenga entre 8 y 15 caracteres entre letras y números.

        Creamos validación para que:
        -	La contraseña tenga que contener como mínimo una letra mayúscula y un número
        */

        public bool ValidacionContraseña(string clave, out string error)
        {
            error = "";

            // if para ver si la contraseña tiene entre 8 y 15 caracteres
            if(clave.Length < 8 || clave.Length > 15)
            {
                error = "La contraseña debe tener entre 8 y 15 caracteres.";
                return false;
            }


            // Creamos variables bool para ver si tiene mayuscula y ver si tiene numero.
            bool letraMayuscula = false;
            bool TieneNumero = false;

            foreach (char c in clave)
            {
                if (char.IsUpper(c))
                {
                    letraMayuscula = true;
                }
                else if (char.IsDigit(c))
                {
                    TieneNumero = true;
                }

                if(letraMayuscula && TieneNumero)
                {
                    return true; // significa que se cumple que tiene la contraseña una letra mayuscula y tiene un numero.
                   
                }
            }

            if (!letraMayuscula || !TieneNumero)
            {
                error = "La contraseña tiene que contener como minimo una letra mayuscula y un número.";
                return false;
            }


            /*
            Si la contraseña ingresada contiene entre 8 y 15 caracteres entre letras y numeros, 
            y además la contraseña contiene como mínimo una letra mayúscula y un número
            ahi entonces ok validación. 
            */
            return true;
            


        }

        // Validación de campos de texto como nombre, apellido y dirección
        public bool ValidarCadena(string input, string campo, int minLength, int maxLength, out string mensajeError)
        {
            if (string.IsNullOrEmpty(input) || input.Length < minLength || input.Length > maxLength)
            {
                mensajeError = $"{campo} debe tener entre {minLength} y {maxLength} caracteres.";
                return false;
            }
            mensajeError = string.Empty;
            return true;
      
        
        }
        public bool ValidarEntero(string input, string campo, int min, int max, out int resultado, out string mensajeError)
        {
            if (int.TryParse(input, out resultado) && resultado >= min && resultado <= max)
            {
                mensajeError = string.Empty;
                return true;
            }
            mensajeError = $"{campo} debe ser un número entre {min} y {max}.";
            resultado = 0;
            return false;
        }
        public bool ValidarEmail(string input, out string mensajeError)
        {
            if (Regex.IsMatch(input, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                mensajeError = string.Empty;
                return true;
            }
            mensajeError = "Formato de correo electrónico inválido.";
            return false;
        }

    }

}
