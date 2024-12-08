using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
        public class entEmpleado
        {
            public int idEmpleado { get; set; } 
            public required string nombres { get; set; } 
            public required string contraseña { get; set; } 
            public required string nombrecompleto { get; set; } 
            public required string correoelectronico { get; set; } 
            public bool estado { get; set; } 
            public required string puesto { get; set; } 
            public decimal salario { get; set; } 
            public required string telefono { get; set; }
            public required string direccion { get; set; }
        }
}
