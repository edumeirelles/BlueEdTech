using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TesteSucessoEventos.Models;
using TesteSucessoEventos.Services;

namespace TesteSucessoEventos.Controllers
{
    public class PacotesController : Controller
    {
        IPacoteService _service;

        public PacotesController(IPacoteService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View(_service.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pacote pacote)
        {
            if (!ModelState.IsValid) return View(pacote);

            if (_service.Create(pacote))
                return RedirectToAction(nameof(Index));
            else
                return View(pacote);
        }
        public IActionResult Read(int id)
        {
            return _service.Get(id) != null ? View(_service.Get(id)) : NotFound();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_service.GetAll().FirstOrDefault(p => p.Id == id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Pacote pacote)
        {
            if (!ModelState.IsValid) return View(pacote);

            if (_service.Update(pacote))
                return RedirectToAction(nameof(Index));
            else
                return NotFound();
        }
        public IActionResult Delete(int? id)
        {
            if (_service.Delete(id))
                return RedirectToAction(nameof(Index));
            else
                return NotFound();
        }
        public IActionResult Confirm(int? id)
        {
            return _service.GetAll().FirstOrDefault(p => p.Id == id) != null ?
                View(_service.GetAll().FirstOrDefault(p => p.Id == id)) :
                RedirectToAction(nameof(Index));
        }
    }
}
