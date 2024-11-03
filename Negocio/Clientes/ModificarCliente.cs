using Datos;
using Persistencia.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Utils
{
    public class ModificarCliente
    {
        private readonly ClientesData _clientesData;

        public ModificarCliente()
        {
            _clientesData = new ClientesData();
        }

        public async Task<bool> ActualizarCliente(ClientesWS cliente)
        {
            return await _clientesData.ActualizarCliente(cliente);
        }
    }
}
