using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClientesWS
    {
        Guid _id;
        string _nombre;
        string _apellido;
        int _dni;
        string _direccion;
        string _telefono;
        string _email;
        DateTime _fechanacimiento;
        DateTime _fechaalta;
        string _host;

        public ClientesWS(Guid id, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechanacimiento, DateTime fechaalta, string host)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            FechaNacimiento = fechanacimiento;
            FechaAlta = fechaalta;
            Host = host;
        }

        public Guid Id { get => _id ; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Dni { get => _dni ; set => _dni = value; }
        public string Direccion { get => _direccion ; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email ; set => _email = value; }
        public DateTime FechaNacimiento { get => _fechanacimiento; set => _fechanacimiento = value; }
        public DateTime FechaAlta { get => _fechaalta; set => _fechaalta = value; }
        public string Host { get => _host; set => _host = value; }

    }
}
