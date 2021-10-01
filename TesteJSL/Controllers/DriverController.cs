using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TesteJSL.Models;
using TesteJSL.Services;

namespace TesteJSL.Controllers
{
    public class DriverController : Controller
    {
        IDriverService _service;
        public DriverController(IDriverService service)
        {
            _service = service;
        }
        
        public IActionResult Index()
        {
            return View(_service.GetAll());
        }
        public IActionResult Read(int id)
        {
            return _service.Get(id) != null ? View(_service.Get(id)) : NotFound();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Driver driver)
        {
            if (!ModelState.IsValid) return View();

            if (_service.Create(driver))
            {
                return RedirectToAction(nameof(Index));
            }
            else
                return View(driver);
        }
        public IActionResult Update(int id)
        {
            return View(_service.GetAll().FirstOrDefault(d => d.Id == id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Driver driver)
        {
            if (!ModelState.IsValid) return View(driver);

            if (_service.Update(driver))
            {
                return RedirectToAction(nameof(Index));
            }
            else
                return NotFound();
        }
        public IActionResult Delete(int? id)
        {
            if (_service.Delete(id))
            {
                return RedirectToAction(nameof(Index));
            }
            else
                return NotFound();
        }
        public IActionResult Confirm(int? id)
        {
            return _service.GetAll().FirstOrDefault(d => d.Id == id) != null ? 
                View(_service.GetAll().FirstOrDefault(d => d.Id == id)) : 
                RedirectToAction(nameof(Index));
        }
    }
}
