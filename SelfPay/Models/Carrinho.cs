using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SelfPay.Models
{
    public class Carrinho
    {
        [Key]
        public int Carrinho_id { get; set; }
        public DateTime Carrinho_dataCadastro { get; set; }
        public int Cliente_id { get; set; }
        public decimal Carrinho_total { get; set; }


        public ICollection<CarrinhoItens> Itens { get; set; } = new List<CarrinhoItens>();
        public Pedido Pedido { get; set; }
        public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
        public Carrinho()
        {

        }

        public Carrinho(int carrinho_id, DateTime carrinho_dataCadastro, int cliente_id, decimal carrinho_total, Pedido pedido)
        {
            Carrinho_id = carrinho_id;
            Carrinho_dataCadastro = carrinho_dataCadastro;
            Cliente_id = cliente_id;
            Carrinho_total = carrinho_total;
            Pedido = pedido;
        }
    }
}
