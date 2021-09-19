using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Drogaria_DrogaVida.Models
{
    public class Produto
    {   
        [Key]
        public int Id_produto { get; set; }
        public string nome { get; set; }
        public string cod_barra { get; set; }
        public string descricao { get; set; }
        public Nullable<System.DateTime> validade { get; set; }
        public string marca { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<int> qda_estoque { get; set; }
        public byte[] imagem { get; set; }
        public Nullable<double> valor { get; set; }
    }
}