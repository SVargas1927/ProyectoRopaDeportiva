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
    
    public partial class OrdenesR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdenesR()
        {
            this.DetallesOR = new HashSet<DetallesOR>();
        }
    
        public string Ord_id { get; set; }
        public string Ord_clienteId { get; set; }
        public string Ord_fecha { get; set; }
        public string Ord_estado { get; set; }
        public string Ord_vendedorId { get; set; }
    
        public virtual ClientesR ClientesR { get; set; }
        public virtual VendedoresR VendedoresR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallesOR> DetallesOR { get; set; }
    }
}
