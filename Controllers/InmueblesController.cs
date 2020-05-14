using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class InmueblesController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly RepositorioPropietario repositorioPropietario;
        private readonly RepositorioInmueble repositorioInmueble;
        private readonly RepositorioContrato repositorioContrato;


        public InmueblesController(IConfiguration configuration)
        {
            this.configuration = configuration;
            repositorioInmueble = new RepositorioInmueble(configuration);
            repositorioPropietario = new RepositorioPropietario(configuration);
            repositorioContrato = new RepositorioContrato(configuration);
        }

        // GET: Inmueble
        public ActionResult Index()
        {
            var lista = repositorioInmueble.ObtenerTodos();
            return View(lista);
        }

        // GET: Inmueble/Details/5
        public ActionResult Details(int id)
        {
            var entidad = repositorioInmueble.ObtenerPorId(id);
            return View(entidad);
        }

        // GET: Inmueble/Create
        public ActionResult Create()
        {
            var p = repositorioPropietario.ObtenerTodos();
            ViewBag.Propietarios = p;
            return View();
        }

      
        // POST: Inmueble/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Inmueble entidad)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repositorioInmueble.Alta(entidad);
                    TempData["IdInmueble"] = entidad.IdInmueble;
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Propietarios = repositorioPropietario.ObtenerTodos();
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

        // GET: Inmueble/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var e = repositorioInmueble.ObtenerPorId(id);
                ViewBag.Propietarios = repositorioPropietario.ObtenerTodos();
                return View(e);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        // POST: Inmueble/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Inmueble e)
        {

            try
            {
                // TODO: Add insert logic here
                int res = repositorioInmueble.Modificacion(e);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        // GET: Inmueble/Eliminar/5
        public ActionResult Delete(int id)
        {
            try
            {
                var e = repositorioInmueble.ObtenerPorId(id);
                return View(e);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        // POST: Inmueble/Eliminar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Inmueble entidad)
        {
            try
            {
                // TODO: Add insert logic here
                //var e = repositorio.ObtenerPorId(id);
                int res = repositorioInmueble.Baja(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        public ActionResult MostrarInmueblesPorPropietario(int id)
        {
            try
            {
                var lista = repositorioInmueble.BuscarPorPropietario(id);
                ViewBag.IdPropietario = id;
                return View(lista);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        
         public ActionResult FiltrarPorDisponibles()
        {
            try
            {
                var lista = repositorioInmueble.MostrarDisponibles();
                return View(lista);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        public ActionResult ListarContratos(int id)
        {
            var lista = repositorioContrato.BuscarPorInmueble(id);
            return View(lista);
        }

        

    }
}