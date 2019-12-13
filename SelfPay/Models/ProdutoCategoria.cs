using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SelfPay.Models
{
    public class ProdutoCategoria
    {
        [Key]
        public int Categoria_id { get; set; }
        public int Produto_id { get; set; }
        public DateTime ProdutoCategoria_dataCadastro { get; set; }

        public ProdutoCategoria()
        {

        }

        public ProdutoCategoria(int categoria_id, int produto_id, DateTime produtoCategoria_dataCadastro)
        {
            Categoria_id = categoria_id;
            Produto_id = produto_id;
            ProdutoCategoria_dataCadastro = produtoCategoria_dataCadastro;
        }
    }
}
