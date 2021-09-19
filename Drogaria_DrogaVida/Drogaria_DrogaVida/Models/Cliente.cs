using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Drogaria_DrogaVida.Models
{
    public class Cliente
    {
        public string nome { get; set; }
        [Key]
        public string cpf_c { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string tel { get; set; }
        public string endereco { get; set; }
        public string datanas { get; set; }
    }
}