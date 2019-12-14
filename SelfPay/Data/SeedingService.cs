using SelfPay.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SelfPay.Data
{
    public class SeedingService
    {
        private SelfPayContext _context;
        public SeedingService(SelfPayContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            //if(_context.Cliente.Any()||
            //    _context.Pedido.Any()||
            //    _context.Produto.Any())
            //{
            //    return; //DB ja Foi populado
            //}
            List<Cliente> listaCliente = new List<Cliente>();

            Cliente c1 = new Cliente(1, "Bruno Amaral", "bruno_henrique_a@hotmail.com", DateTime.Parse("16/02/1991"), null);
            Cliente c2 = new Cliente(2, "Joao   Silva", "joao_silva@hotmail.com", DateTime.Parse("10/01/2009"), null);
            Cliente c3 = new Cliente(3, "Paula Santos", "paula_santos@hotmail.com", DateTime.Parse("04/10/2010"), null);
            Cliente c4 = new Cliente(4, "Maria Rocha", "maria_rocha@hotmail.com", DateTime.Parse("07/07/1995"), null);

            listaCliente.Add(c1);
            listaCliente.Add(c2);
            listaCliente.Add(c3);
            listaCliente.Add(c4);

            Pedido ped1 = new Pedido(1, 100, 1, DateTime.Parse("10/10/2010"), null);
            Pedido ped2 = new Pedido(2, 200, 1, DateTime.Parse("12/08/2000"), null);
            Pedido ped3 = new Pedido(3, 150, 1, new DateTime(2001,06,01), null);
            Pedido ped4 = new Pedido(4, 10, 1, new DateTime(2008,03,05), null);

            Produto prod1 = new Produto(1, "livro", 0, "Sim", 100, 100);
            Produto prod2 = new Produto(2, "caderno", 0, "Sim", 200, 100);
            Produto prod3 = new Produto(3, "mala", 0, "Sim", 200, 100);
            Produto prod4 = new Produto(4, "bicicleta", 0, "Sim", 300, 100);

            _context.Cliente.AddRange(listaCliente);
            _context.Pedido.AddRange(ped1, ped2, ped3, ped4);
            _context.Produto.AddRange(prod1, prod2, prod3, prod4);

            var teste = _context.SaveChanges();
            Debug.WriteLine(teste);

        https://stackoverflow.com/questions/3031412/how-to-export-a-mysql-database-using-command-prompt
        }
    }
    
}
