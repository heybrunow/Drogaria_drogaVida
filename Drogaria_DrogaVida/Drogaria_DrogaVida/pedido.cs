//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Drogaria_DrogaVida
{
    using System;
    using System.Collections.Generic;
    
    public partial class pedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pedido()
        {
            this.receita1 = new HashSet<receita>();
        }
    
        public int Id_pedido { get; set; }
        public Nullable<double> valor { get; set; }
        public byte[] receita { get; set; }
        public string mdp { get; set; }
        public Nullable<System.DateTime> hdp { get; set; }
        public Nullable<int> qdadproduto { get; set; }
        public string cpf_c { get; set; }
        public string cpf_o { get; set; }
        public Nullable<int> Id_produto { get; set; }
        public Nullable<int> Id_aprovacao { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual operador operador { get; set; }
        public virtual produto produto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<receita> receita1 { get; set; }
        public virtual receita receita2 { get; set; }
    }
}