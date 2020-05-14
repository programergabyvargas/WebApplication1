using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PagosController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly RepositorioPago repositorioPago;
        private readonly RepositorioContrato repositorioContrato;
        public PagosController(IConfiguration configuration)
        {
            this.configuration = configuration;
            repositorioPago = new RepositorioPago(configuration);
            repositorioContrato = new RepositorioContrato(configuration);
        }
        // GET: Pagos
        public ActionResult Index()
        {
            var lista = repositorioPago.ObtenerTodos();
            return View(lista);
        }

        public ActionResult PorContrato(int id)
        {
            var lista = repositorioPago.BuscarPorContrato(id);
            ViewBag.IdContrato = id;
            return View(lista);
        }

        // GET: Pagos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pagos/Create
        public ActionResult Create(int id)
        {
            var c = repositorioContrato.ObtenerPorId(id);
            ViewBag.Contrato = c;
            return View();
        }

        // POST: Pagos/Create
        [HttpPost]
        
        public ActionResult Create(Pago p)
        {
            try
            {
                // TODO: Add insert logic here
                int res = repositorioPago.Alta(p);
                return RedirectToAction(nameof(PorContrato), new {id=p.IdContrato});
            }
            catch
            {
                return View();
            }
        }

        // GET: Pagos/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var e = repositorioPago.ObtenerPorId(id);
                return View(e);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        // POST: Pagos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Pago e)
        {
            try
            {
                // TODO: Add insert logic here
          
                int res = repositorioPago.Modificacion(e);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        // GET: Pagos/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var pago = repositorioPago.ObtenerPorId(id);
                return View(pago);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        // POST: Pagos/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Pago e)
        {
            try
            {
                int res = repositorioPago.Baja(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }
    }
}