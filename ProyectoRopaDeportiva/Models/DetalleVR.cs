//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoRopaDeportiva.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleVR
    {
        public string Vde_detalleId { get; set; }
        public string Vde_ventaId { get; set; }
        public string Vde_productoId { get; set; }
        public string Vde_cantidad { get; set; }
        public string Vde_precioUnitario { get; set; }
        public string Vde_subtotal { get; set; }
    
        public virtual ProductosR ProductosR { get; set; }
        public virtual VentasR VentasR { get; set; }
    }
}