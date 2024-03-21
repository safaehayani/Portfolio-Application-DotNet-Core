using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Entities;


namespace Infrastructure
{
   public  class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options): base(options) { 

        
        }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<PorfolioItem> PorfolioItems { get; set; }


    }
}
