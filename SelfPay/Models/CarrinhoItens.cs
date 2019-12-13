using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SelfPay.Models
{
    public class CarrinhoItens
    {
        [Key]
        public int CarrinhoItens_id { get; set; }
        public int CarrinhoItens_carrinho_id { get; set; }
        public int Carrinhoitens_produto_id { get; set; }
        public decimal CarrinhoItens_valorUnitario { get; set; }
        public decimal CarrinhoItens_valorTotalItem { get; set; }
        public int CarrinhoItens_quantidade { get; set; }
        public DateTime CarrinhoItens_dataCadatro { get; set; }


        public ICollection<PedidoItens> PedidoItenss { get; set; } = new List<PedidoItens>();
        public Carrinho Carrinho { get; set; }

        public CarrinhoItens()
        {

        }

        public CarrinhoItens(int carrinhoItens_id, int carrinhoItens_carrinho_id, int carrinhoitens_produto_id, decimal carrinhoItens_valorUnitario, decimal carrinhoItens_valorTotalItem, int carrinhoItens_quantidade, DateTime carrinhoItens_dataCadatro, Carrinho carrinho)
        {
            CarrinhoItens_id = carrinhoItens_id;
            CarrinhoItens_carrinho_id = carrinhoItens_carrinho_id;
            Carrinhoitens_produto_id = carrinhoitens_produto_id;
            CarrinhoItens_valorUnitario = carrinhoItens_valorUnitario;
            CarrinhoItens_valorTotalItem = carrinhoItens_valorTotalItem;
            CarrinhoItens_quantidade = carrinhoItens_quantidade;
            CarrinhoItens_dataCadatro = carrinhoItens_dataCadatro;
            Carrinho = carrinho;
        }
    }
}
