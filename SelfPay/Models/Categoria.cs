using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SelfPay.Models
{
    public class Categoria
    {
        [Key]
        public int Categoria_id { get; set; }
        public string Categoria_nome { get; set; }
        public string Categoria_ativo { get; set; }
        public DateTime Categoria_dataCadastro { get; set; }

        public Categoria()
        {

        }

        public Categoria(int categoria_id, string categoria_nome, string categoria_ativo, DateTime categoria_dataCadastro)
        {
            Categoria_id = categoria_id;
            Categoria_nome = categoria_nome;
            Categoria_ativo = categoria_ativo;
            Categoria_dataCadastro = categoria_dataCadastro;
        }
    }
}
