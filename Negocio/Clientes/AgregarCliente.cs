using Datos;
using Persistencia.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Clientes
{
    public class AgregarClienteWS
    {
        private readonly ClientesData _clientesData;

        public AgregarClienteWS()
        {
            _clientesData = new ClientesData();
        }
        public bool AgregarCliente(string nombre,string apellido,DateTime fecha,int dni,string telefono,string email,string domicilio)
        {
            if (!int.TryParse(telefono, out int tel) || !email.Contains('@') || dni.ToString().Length != 8)
            {
                return false;
            }
            else if (1!=1)
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
