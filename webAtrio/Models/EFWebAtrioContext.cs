using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAtrio.Models
{
    public class EFWebAtrioContext : DbContext
    {
        public EFWebAtrioContext(DbContextOptions<EFWebAtrioContext> options)
            : base(options)
        {

        }

        public DbSet<Personne> Personnes { get; set; }
    }
}
