using DesafioSoftplan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioSoftplan.Services
{
    public class calculaJurosService
    {
        public calculaJuros CalculaJuros(decimal valorInicial, int tempo)
        {
            calculaJuros calculaJurosService = new()
            {
                Tempo = tempo,
                ValorInicial = valorInicial
            };

            return calculaJurosService;
        }
    }
}
