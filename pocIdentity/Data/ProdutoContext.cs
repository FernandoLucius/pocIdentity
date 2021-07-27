using Microsoft.EntityFrameworkCore;
using pocIdentity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pocIdentity.Data
{
    public class ProdutoContext : DbContext
    {
        private const string ConnectionString = "Data Source=DESKTOP-6BPP2TB/SQLEXPRESS;Password=poc;Persist Security Info=True;User ID=poc;Initial Catalog=pocIdentity;";

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        
    }
}
