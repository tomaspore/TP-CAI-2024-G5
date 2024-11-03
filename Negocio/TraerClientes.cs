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
        private readonly ClientesData _listadoClientes;

        public TraerClientes(ClientesData listadoClientes)
        {
            _listadoClientes = listadoClientes ?? throw new ArgumentNullException(nameof(listadoClientes));
        }

        public async Task<List<ClientesWS>> ObtenerClientesAsync()
        {
            try
            {
                return await _listadoClientes.ListadoClientes();
            }
            catch (Exception ex)
            {
                // Manejo de errores o log
                Console.WriteLine($"Error al obtener clientes: {ex.Message}");
                return new List<ClientesWS>();
            }
        }
    }
}
