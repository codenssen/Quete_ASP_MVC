using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Quete_ASP_MVC.Models;

namespace Quete_ASP_MVC.Data
{
    public class Quete_ASP_MVCContext : DbContext
    {
        public Quete_ASP_MVCContext (DbContextOptions<Quete_ASP_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Quete_ASP_MVC.Models.Article> Article { get; set; } = default!;
    }
}
