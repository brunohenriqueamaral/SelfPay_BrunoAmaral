using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SelfPay.Models;

namespace SelfPay.Data
{
    public class SelfPayContext : DbContext
    {
        public SelfPayContext (DbContextOptions<SelfPayContext> options)
            : base(options)
        {
        }

        public DbSet<SelfPay.Models.Produto> Produto { get; set; }
    }
}
