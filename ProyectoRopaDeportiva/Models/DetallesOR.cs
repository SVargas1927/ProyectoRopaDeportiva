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
    
    public partial class DetallesOR
    {
        public string Ode_detalleId { get; set; }
        public string Ode_ordenId { get; set; }
        public string Ode_productoId { get; set; }
        public string Ode_cantidad { get; set; }
        public string Ode_precioU { get; set; }
        public string Ode_subtotal { get; set; }
    
        public virtual OrdenesR OrdenesR { get; set; }
        public virtual ProductosR ProductosR { get; set; }
    }
}
