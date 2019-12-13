using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SelfPay.Models;

namespace SelfPay.Data
{
    public class SelfPayContext : DbContext
    {
        public SelfPayContext (DbContextOptions<SelfPayContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Carrinho> Carrinho { get; set; }
        public DbSet<CarrinhoItens> Carrinhoitens { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoItens> PedidoItens { get; set; }
        public DbSet<ProdutoCategoria> ProdutoCategoria { get; set; }


    }
}
