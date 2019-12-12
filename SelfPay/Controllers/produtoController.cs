using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SelfPay.Models;

namespace SelfPay.Controllers
{
    public class produtoController : Controller
    {
        public IActionResult Index()
        {

            List<Produto> list = new List<Produto>();
            list.Add(new Produto { produto_id = 1, produto_nome = "livro", produto_desc = 0.50M , produto_ativo = "sim", produto_preco = 10.50M, produto_precoPromo = 10.00M });

            return View(list);
        }
    }
}