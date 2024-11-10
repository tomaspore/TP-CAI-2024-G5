using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Persistencia.Clientes;

namespace Negocio.Utils
{
    public class BorrarCliente
    {
        public bool BajaClienteNegocio(string idCliente)
        {
            DeleteCliente deletecliente = new DeleteCliente();

            bool response = deletecliente.BajaCliente(idCliente);

            if(!response)
            {
                return false;
            }

            return true;
        }
    }
}
