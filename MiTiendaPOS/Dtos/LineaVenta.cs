using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTiendaPOS.Dtos
{
    public class LineaVenta
    {
        public int ProductoId { get; set; }
        public string Producto { get; set; } = "";
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal => Cantidad * PrecioUnitario; // propiedad calculada
    }
}
