using DesafioSoftplan.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioSoftplan.Controllers
{
    public class CalculaJurosController : Controller
    {
        calculaJurosService _service;
        taxaJurosService _taxaJurosService;
        public CalculaJurosController(calculaJurosService service, taxaJurosService taxaJurosService)
        {
            _service = service;
            _taxaJurosService = taxaJurosService;
        }
        public IActionResult Index(decimal valorInicial=100, int tempo=5)
        {
            ViewBag.taxaJuros = _taxaJurosService.GetTaxaJuros().TaxaJuros;
            var calculaJuros = _service.CalculaJuros(valorInicial,tempo);
            calculaJuros.ValorFinal = Math.Truncate((decimal)(calculaJuros.ValorInicial * (decimal)Math.Pow(1 + (double)_taxaJurosService.GetTaxaJuros().TaxaJuros, tempo)*100)) /100;
            
            return View(calculaJuros);

        }
    }
}
