using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia;
using Persistencia.Clientes;
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

            public Guid BuscarClientePorDNI(int dni)
            {
                ClientesData clientesData = new ClientesData();
                List<ClientesWS> clientes = clientesData.ListadoClientes().Result;

                ClientesWS cliente = clientes.FirstOrDefault(c => c.Dni == dni);
                return cliente != null ? cliente.Id : Guid.Empty;
            }
        
        
    }
}

