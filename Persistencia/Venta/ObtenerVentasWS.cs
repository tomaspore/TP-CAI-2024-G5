using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Venta
{
    public class ObtenerVentasWS
    {
        public List<Venta> ObtenerVentasFicticias()
        {
            
            List<Venta> ventasFicticias = new List<Venta>
            {
                new Venta
                {
                    Id = Guid.NewGuid(),
                    NombreCliente = "Juan Pérez",
                    NombreUsuario = "Carlos López",
                    NombreProducto = "Televisor 55 pulgadas",
                    Cantidad = 5,
                    FechaAlta = DateTime.Now.AddDays(-10),
                    Estado = 1
                },
                new Venta
                {
                    Id = Guid.NewGuid(),
                    NombreCliente = "María García",
                    NombreUsuario = "Ana Torres",
                    NombreProducto = "Laptop Gaming",
                    Cantidad = 2,
                    FechaAlta = DateTime.Now.AddDays(-7),
                    Estado = 1
                },
                new Venta
                {
                    Id = Guid.NewGuid(),
                    NombreCliente = "Pedro Rodríguez",
                    NombreUsuario = "Luis Martínez",
                    NombreProducto = "Smartphone",
                    Cantidad = 8,
                    FechaAlta = DateTime.Now.AddDays(-3),
                    Estado = 0
                },
                
            };

            return ventasFicticias;
        }
    }
}
