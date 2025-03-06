using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using VistaEfecty.Models;
using VistaEfecty.Service;

namespace VistaEfecty.Controllers
{
    public class HomeController(HttpServices httpService) : Controller
    {
        private readonly HttpServices _httpService = httpService;

        public async Task<IActionResult> Index()
        {
            List<Prueba>? pruebas = await GetCadidatosAsync();

            PruebaViewModel model = new()
            {
                Pruebas = pruebas,
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RegistrarCandidato(PruebaViewModel candidato)
        {
            if (ModelState.IsValid)
            {
                await _httpService.AddPruebaAsync(candidato.Prueba);
                TempData["Mensaje"] = "Candidato registrado exitosamente";
                return RedirectToAction("Index");
            }

            List<Prueba>? pruebas = await GetCadidatosAsync();

            PruebaViewModel model = new()
            {
                Pruebas = pruebas,
            };

            return View("Index", model);
        }

        [HttpGet]
        public async Task<List<Prueba>?> GetCadidatosAsync()
        {
            return await _httpService.GetPruebaAsync();
        }
    }
}
