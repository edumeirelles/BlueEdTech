using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_EMix.Models;
using Teste_EMix.Services;

namespace Teste_EMix.Controllers
{
    public class CepController : Controller
    {
        ICepService _service;
        IWebCepService _webService;

        public CepController(ICepService service, IWebCepService webService)
        {
            _service = service;
            _webService = webService;
        }

        public IActionResult Index()
        {
            
            return View();
            
        }

        public IActionResult Read(string search)
        {
            ViewBag.ErrorMessage = "";

            if (search != null)
            {
                if (search.Length != 8)
                {
                    ViewBag.ErrorMessage = "CEP Inválido";
                    return View(nameof(Index));
                }
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }

            string searchFormat = Convert.ToUInt64(search).ToString(@"00000\-000");

            CEP cep = _service.Get(searchFormat);
            if (cep == null)
            {
                ViewBag.ErrorMessage = "CEP Não Encontrado";
                return View(nameof(Index));
            }

            return View(cep);

        }

        public IActionResult WebSearch(string search)
        {
            if (search != null)
            {
                if (search.Length != 8)
                {
                    ViewBag.ErrorMessage = "CEP Inválido";
                    return View(nameof(Index));
                }
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }

            CEP cep = _webService.GetWebCep(search);

            if (cep.cep == null)
            {
                ViewBag.ErrorMessage = "CEP Não Encontrado";
                return View(nameof(Index));
            }

            return View(cep);
        }
    }
}
