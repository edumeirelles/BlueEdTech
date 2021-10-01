using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using TesteSucessoEventos.Models;
using TesteSucessoEventos.Services;

namespace TesteSucessoEventos.Controllers
{
    public class ParticipantesController : Controller
    {
        IParticipanteService _service;
        IPacoteService _pacoteService;
        IAtividadeService _atividadeService;

        public ParticipantesController(IParticipanteService service, IPacoteService pacoteService, IAtividadeService atividadeService)
        {
            _service = service;
            _pacoteService = pacoteService;
            _atividadeService = atividadeService;
        }
        public IActionResult Index()
        {
            return View(_service.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            //ViewBag.atividades = new SelectList(_atividadeService.GetAll().Select(a => new { a.Id, name = a.DescAtv + " - R$ " + a.Price}), "Id", "name");
            ViewBag.atividades = _atividadeService.GetAll().ToList();
            ViewBag.pacotes = new SelectList(_pacoteService.GetAll().Select(p => new { p.Id, name = p.DescPkg + " - R$ " + p.Price}), "Id", "name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Participante participante)
        {
            if (!ModelState.IsValid) return View(participante);

            if (_service.Create(participante))
                return RedirectToAction(nameof(Index));
            else
                return View(participante);
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
        public IActionResult Update(Participante participante)
        {
            if (!ModelState.IsValid) return View(participante);

            if (_service.Update(participante))
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
