using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace pc3.Models
{
    public class PruebaContext : DbContext
    {
        public DbSet<Prueba> Pruebas {get;set;}

        public PruebaContext(DbContextOptions options) : base(options){
            
        }
    }
}