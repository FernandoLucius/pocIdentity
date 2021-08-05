using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using pocIdentity.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace pocIdentity.Data
{
    public class ContextoBase : IdentityDbContext
    {
        public ContextoBase(DbContextOptions<ContextoBase> options) : base(options) { }
        public DbSet<Produto> Produtos { get; set; }
    }
}
