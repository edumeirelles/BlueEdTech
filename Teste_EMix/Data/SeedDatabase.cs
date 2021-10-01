using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_EMix.Models;

namespace Teste_EMix.Data
{
    public static class SeedDatabase
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CepContext(
                serviceProvider.GetRequiredService<DbContextOptions<CepContext>>()))
            {
                if (context.CEP.Any())
                {
                    return;
                }

                context.CEP.Add(new CEP { 
                    cep = "04145-030",
                    logradouro = "Rua Visconde de Inhaúma",
                    complemento = "",
                    bairro = "Vila da Saúde",
                    localidade = "São Paulo",
                    uf = "SP",
                    ibge = 3550308,
                    unidade = 11,
                    gia = "1004"
                });
                

                context.SaveChanges();
            }
        }
    }
}
