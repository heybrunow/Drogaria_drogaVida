using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Drogaria_DrogaVida.Models
{
    public class Receita
    {
        [Key]
        public int Id_aprovacao { get; set; }
        public Nullable<bool> status_receita { get; set; }
        public byte[] receita1 { get; set; }
        public string cpf_o { get; set; }
        public Nullable<int> Id_pedido { get; set; }
    }
}