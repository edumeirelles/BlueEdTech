using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_EMix.Models;

namespace Teste_EMix.Services
{
    public interface IWebCepService
    {
        public CEP GetWebCep(string search);
    }
}
