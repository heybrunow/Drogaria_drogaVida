using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Drogaria_DrogaVida.Models
{
    public class Pedido
    {
        [Key]
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
    }
}