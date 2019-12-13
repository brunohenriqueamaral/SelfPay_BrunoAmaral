using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SelfPay.Models
{
    public class Cliente
    {
        [Key]
        public int Cliente_id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
       public Carrinho Carrinho { get; set; }

        public Cliente()
        {

        }

        public Cliente(int cliente_id, string nome, string email, DateTime dataCadastro, Carrinho carrinho)
        {
            Cliente_id = cliente_id;
            Nome = nome;
            Email = email;
            DataCadastro = dataCadastro;
            Carrinho = carrinho;
        }
    }
}
