using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSucessoEventos.Models;

namespace TesteSucessoEventos.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Participante> Participantes { get; set; }
        public DbSet<Atividade> Atividades { get; set; }
        public DbSet<Pacote> Pacotes { get; set; }
        
    }
}
