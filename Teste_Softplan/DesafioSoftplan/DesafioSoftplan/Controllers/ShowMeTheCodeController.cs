using DesafioSoftplan.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesafioSoftplan.Controllers
{
    public class ShowMeTheCodeController : Controller
    {
        public IActionResult Index()
        {
            showMeTheCode showMeTheCode = new();

            return View(showMeTheCode);
        }
    }
}
