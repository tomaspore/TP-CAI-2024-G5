using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTPIntegrador
{
    public class ValidacionesUtils
    {

        public bool ValidarVacio(string texto1, string texto2)
        {
            int intentos;

            if (string.IsNullOrEmpty(texto1) && string.IsNullOrEmpty(texto2))
            {

                return true;

            }
            else if (string.IsNullOrEmpty(texto1) || string.IsNullOrEmpty(texto2))
            {

                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
