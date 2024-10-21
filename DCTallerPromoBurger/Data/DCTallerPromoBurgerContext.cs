using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DCTallerPromoBurger.Models;

public class DCTallerPromoBurgerContext : DbContext
    {
        public DCTallerPromoBurgerContext (DbContextOptions<DCTallerPromoBurgerContext> options)
            : base(options)
        {
        }

        public DbSet<Burger> Burger { get; set; } = default!;
    }
