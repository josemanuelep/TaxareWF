//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Broker
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inventario()
        {
            this.Gasto_Inventario = new HashSet<Gasto_Inventario>();
        }

        public Inventario(int id, string item, int cantidad, double valorUnitario, double valorTotal)
        {
            this.id = id;
            this.item = item;
            this.cantidad = cantidad;
            this.valorUnitario = valorUnitario;
            this.valorTotal = valorTotal;
        }

        public int id { get; set; }
        public string item { get; set; }
        public int cantidad { get; set; }
        public double valorUnitario { get; set; }
        public double valorTotal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gasto_Inventario> Gasto_Inventario { get; set; }
    }
}
