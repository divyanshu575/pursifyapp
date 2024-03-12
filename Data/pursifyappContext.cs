using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pursifyapp.Models;

namespace pursifyapp.Data
{
    public class pursifyappContext : DbContext
    {
        public pursifyappContext (DbContextOptions<pursifyappContext> options)
            : base(options)
        {
        }

        public DbSet<pursifyapp.Models.Purse> Purse { get; set; } = default!;
    }
}
