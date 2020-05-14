using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly RepositorioPropietario repositorioPropietario;
        private readonly IConfiguration configuration;

        public HomeController( IConfiguration configuration)
        {
            // this.propietarios = propietarios;
            repositorioPropietario = new RepositorioPropietario(configuration);
            this.configuration = configuration;
        }
        public IActionResult Index()
        {
            ViewBag.Titulo = "Página de Inicio";
            List<string> clientes = repositorioPropietario.ObtenerTodos().Select(x => x.Nombre + " " + x.Apellido).ToList();
            return View(clientes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize]
        public IActionResult Autenticado()
        {
            return View();
        }

        [Authorize(Policy = "Administrador")]
        public IActionResult SuperPrivado()
        {
            return View();
        }


        public IActionResult Restringido()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
