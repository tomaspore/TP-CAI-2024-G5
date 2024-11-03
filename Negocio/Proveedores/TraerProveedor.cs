using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio.Utils
{
    public class TraerProveedor
    {
        private readonly Proveedores proveedoresPersistencia = new Proveedores();

        public async Task<List<Proveedor>> ObtenerProveedoresAsync()
        {
            return await proveedoresPersistencia.ObtenerProveedoresAsync();
        }

    }
}
