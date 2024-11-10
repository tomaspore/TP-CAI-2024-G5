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
        private readonly DeleteCliente _deleteCliente;

        public BorrarCliente(DeleteCliente deleteCliente)
        {
            _deleteCliente = deleteCliente ?? throw new ArgumentNullException(nameof(deleteCliente));
        }

        public bool BajaClienteNegocio(string idCliente)
        {
            try
            {
                return _deleteCliente.BajaCliente(idCliente);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al borrar cliente: {ex.Message}");
                return false;
            }
        }
    }
}
