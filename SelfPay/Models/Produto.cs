using FluentNHibernate.Conventions.Helpers;
using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SelfPay.Models
{
    public class Produto
    {
       [Key]
        public int Produto_id { get; set; }
        public string Produto_nome { get; set; }
        public decimal Produto_desc { get; set; }
        public string Produto_ativo { get; set; }
        public decimal Produto_preco { get; set; }
        public decimal Produto_precoPromo { get; set; }


        public PedidoItens PedidoItens { get; set; }

        public Produto()
        {

        }

        public Produto(int produto_id, string produto_nome, decimal produto_desc, string produto_ativo, decimal produto_preco, decimal produto_precoPromo)
        {
            Produto_id = produto_id;
            Produto_nome = produto_nome;
            Produto_desc = produto_desc;
            Produto_ativo = produto_ativo;
            Produto_preco = produto_preco;
            Produto_precoPromo = produto_precoPromo;
        }
    }
}
