using DesafioSoftplan.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioSoftplan.Services;

namespace DesafioSoftplan.Controllers
{
    public class TaxaJurosController : Controller
    {
        taxaJurosService _service;
        public TaxaJurosController(taxaJurosService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View(_service.GetTaxaJuros());
        }
    }
}
