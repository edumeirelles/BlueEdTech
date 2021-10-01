using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_EMix.Models;

namespace Teste_EMix.Data
{
    public class CepContext : DbContext
    {
        public CepContext(DbContextOptions<CepContext> options) : base(options) { }

        public DbSet<CEP> CEP { get; set; }
    }
}
