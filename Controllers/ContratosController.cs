using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class ContratosController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly RepositorioInquilino repositorioInquilino;
        private readonly RepositorioInmueble repositorioInmueble;
        private readonly RepositorioContrato repositorioContrato;

        public ContratosController(IConfiguration configuration)
        {
            this.configuration = configuration;
            repositorioInmueble = new RepositorioInmueble(configuration);
            repositorioInquilino = new RepositorioInquilino(configuration);
            repositorioContrato = new RepositorioContrato(configuration);
        }
        // GET: Contratos
        public ActionResult Index()
        {
            var lista = repositorioContrato.ObtenerTodos();
            return View(lista);
        }

        // GET: Contratos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Contratos/Create
        public ActionResult Create()
        {
            ViewBag.Inmuebles = repositorioInmueble.ObtenerTodos();
            ViewBag.Inquilinos = repositorioInquilino.ObtenerTodos();
            return View();
        }

        // POST: Contratos/Create
        [HttpPost]
        
        public ActionResult Create(Contrato entidad)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repositorioContrato.Alta(entidad);
                    TempData["IdContrato"] = entidad.IdContrato;
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Contratos = repositorioContrato.ObtenerTodos();
                    return View(entidad);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.StackTrate = ex.StackTrace;
                return View(entidad);
            }
        }

        // GET: Contratos/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var e = repositorioContrato.ObtenerPorId(id);
               // ViewBag.Inmueble = repositorioInmueble.ObtenerTodos();
               // ViewBag.Inquilino = repositorioInquilino.ObtenerTodos();

                return View(e);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        // POST: Contratos/Edit/5
        [HttpPost]
        
        public ActionResult Edit(int id, Contrato e)
        {
            try
            {
                // TODO: Add insert logic here
                int res = repositorioContrato.Modificacion(e);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        // GET: Contratos/Delete/5
        [Authorize(Policy = "Administrador")]
        public ActionResult Delete(int id)
        {
            try
            {
                var e = repositorioContrato.ObtenerPorId(id);
                return View(e);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        // POST: Contratos/Delete/5
        [HttpPost]
        [Authorize(Policy = "Administrador")]
        public ActionResult Delete(int id, Contrato e)
        {
            try
            {
                int res = repositorioContrato.Baja(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        public ActionResult ContratosVigentes(DateTime FechaInicio, DateTime FechaFin)
        {
            try
            {
                var lista = repositorioContrato.ObtenerVigentes(FechaInicio,FechaFin);
                return View(lista);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        
    }
}