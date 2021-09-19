using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Drogaria_DrogaVida.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Produto> Produtos { get; set;}

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<Receita> receitas { get; set; }

        public DbSet<Operador> operadores { get; set; }

        public DbSet<Cliente> clientes { get; set; }
    }
}