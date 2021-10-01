using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_EMix.Data;
using Teste_EMix.Models;

namespace Teste_EMix.Services
{
    public class CepService : ICepService
    {
        CepContext _context;
        public CepService(CepContext context)
        {
            _context = context;
        }
        

        public CEP Get(string search)
        {
            return _context.CEP.ToList().FirstOrDefault(x => x.cep == search);
        }

        

        
    }
}
