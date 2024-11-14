using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Venta;

namespace Negocio.Ventas
{
    public class DevolverVentaNegocio
    {
        DevolverVentaWS devolver = new DevolverVentaWS();
        public bool DevolverVenta(string id)
        {
            bool response = devolver.DevolverVenta(id);

            if(!response)
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
