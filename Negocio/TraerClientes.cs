using Persistencia;
using Persistencia.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class TraerClientes
    {

        private readonly GetClientes listadoclientes = new GetClientes();

       public async Task<List<ClientesWS>> ObtenerClientesAsync()
       {
                return await listadoclientes.ListadoClientes();
       }

       

    }
}
