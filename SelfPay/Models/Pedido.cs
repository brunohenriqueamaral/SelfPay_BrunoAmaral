using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SelfPay.Models
{
    public class Pedido
    {
        [Key]
        public int Pedido_id { get; set; }
        public decimal Pedido_valor { get; set; }
        public int CarrinhoItens_id { get; set; }
        public DateTime Pedido_dataCadastro { get; set; }


        public PedidoItens PedidoItens { get; set; }
        public ICollection<Carrinho> Carrinhos { get; set; } = new List<Carrinho>();

        public Pedido()
        {

        }

        public Pedido(int pedido_id, decimal pedido_valor, int carrinhoItens_id, DateTime pedido_dataCadastro, PedidoItens pedidoItens)
        {
            Pedido_id = pedido_id;
            Pedido_valor = pedido_valor;
            CarrinhoItens_id = carrinhoItens_id;
            Pedido_dataCadastro = pedido_dataCadastro;
            PedidoItens = pedidoItens;
        }
    }
}
