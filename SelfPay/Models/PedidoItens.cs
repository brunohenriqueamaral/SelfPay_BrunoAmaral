using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SelfPay.Models
{
    public class PedidoItens
    {
        [Key]
        public int PedidoItens_id { get; set; }
        public int Pedidoitens_pedido_id  { get; set; }
        public decimal PedidoItens_valorTotal { get; set; }
        public decimal PedidoItens_valorUnidade { get; set; }
        public int PedidoItens_quantidade { get; set; }
        public int PedidoItens_produto_id { get; set; }
        public DateTime PedidoItens_dataCadastro { get; set; }


        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
        public CarrinhoItens CarrinhoItens { get; set; }
        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

        public PedidoItens()
        {

        }

        public PedidoItens(int pedidoItens_id, int pedidoitens_pedido_id, decimal pedidoItens_valorTotal, decimal pedidoItens_valorUnidade, int pedidoItens_quantidade, int pedidoItens_produto_id, DateTime pedidoItens_dataCadastro, CarrinhoItens carrinhoItens)
        {
            PedidoItens_id = pedidoItens_id;
            Pedidoitens_pedido_id = pedidoitens_pedido_id;
            PedidoItens_valorTotal = pedidoItens_valorTotal;
            PedidoItens_valorUnidade = pedidoItens_valorUnidade;
            PedidoItens_quantidade = pedidoItens_quantidade;
            PedidoItens_produto_id = pedidoItens_produto_id;
            PedidoItens_dataCadastro = pedidoItens_dataCadastro;
            CarrinhoItens = carrinhoItens;
        }
    }
}
