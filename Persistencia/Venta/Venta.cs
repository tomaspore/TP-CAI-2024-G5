using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Venta
{
    public class Venta
    {
        public Guid Id { get; set; }
        public string NombreCliente { get; set; }  
        public string NombreUsuario { get; set; }  
        public string NombreProducto { get; set; } 
        public int Cantidad { get; set; }
        public DateTime FechaAlta { get; set; }
        public int Estado { get; set; }
    }
}
