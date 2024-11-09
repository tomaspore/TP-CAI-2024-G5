using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Persistencia.Venta;

namespace Negocio.Ventas
{
    public class AgregarVentaNegocio
    {
        public bool AgregarVenta(string idCliente, string idUsuario, string idProducto, int cantidad)
        {
            AgregarVenta Agregar = new AgregarVenta();

            bool response = Agregar.AgregarVentaCliente(idCliente, idUsuario, idProducto, cantidad);


            if (!response)
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

