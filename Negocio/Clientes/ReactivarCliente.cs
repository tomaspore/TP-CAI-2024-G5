using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Clientes;

namespace Negocio.Clientes
{
    public class ReactivarCliente
    {
        ClientesData _clientesdata = new ClientesData();
        public int ValidarReactivación(string id)
        {
            bool response = _clientesdata.ReactivarCliente(id);

            if (response)
            {
                return 1;
            }
            else
            {
                return 2;
            }

        }
    }
}
