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
    
    public partial class ClientesR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientesR()
        {
            this.OrdenesR = new HashSet<OrdenesR>();
        }
    
        public string Cli_id { get; set; }
        public string Cli_nombre { get; set; }
        public string Cli_apellido { get; set; }
        public string Cli_correo { get; set; }
        public string Cli_direccion { get; set; }
        public string Cli_telefono { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenesR> OrdenesR { get; set; }
    }
}
