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
        public int AgregarCliente(string nombre,string apellido,DateTime fecha,int dni,string telefono,string email,string domicilio)
        {
            string idadmin = "1653c7ec-870d-468a-b581-9800961d53d2";
            string host = "X";
            //Siempre lo va a subir con el mismo id.

            bool response = _clientesData.AgregarCliente(idadmin, nombre, apellido, fecha, dni, telefono, email, domicilio, host);

            if (!int.TryParse(telefono, out int tel) || !email.Contains('@') || dni.ToString().Length != 8)
            {
                return 1;
            }
            else if (!response)
            {

                return 2;
            }
            else
            {

                return 3;
            }
                
        }

    }
}
