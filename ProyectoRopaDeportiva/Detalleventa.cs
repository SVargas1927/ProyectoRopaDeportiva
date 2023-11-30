using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoRopaDeportiva
{
    public class Detalleventa
    {
        public string Vde_detalleId { get; set; }
        public string Vde_ventaId { get; set; }
        public string Vde_productoId { get; set; }
        public string Vde_cantidad { get; set; }
        public string Vde_precioUnitario { get; set; }
        public string Vde_subtotal { get; set; }
        public string ProductosR { get; set; }
        public string VentasR { get; set; }
    }
}