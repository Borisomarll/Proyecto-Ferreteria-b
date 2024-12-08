using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class entProducto
    {
        public int IdProducto { get; set; }
        public required string Nombre { get; set; }
        public required string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int CantidadEnStock { get; set; }
        public int IdCategoria { get; set; }
    }
}
