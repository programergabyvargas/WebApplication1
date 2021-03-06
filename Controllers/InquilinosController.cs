﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class InquilinosController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly RepositorioInquilino repositorio;
        public InquilinosController(IConfiguration configuration)
        {
            this.configuration = configuration;
            repositorio = new RepositorioInquilino(configuration);
        }



        // GET: Inquilino
        public ActionResult Index()
        {
            var lista = repositorio.ObtenerTodos();
            return View(lista);
        }

        // GET: Inquilino/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Inquilino/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Inquilino/Create
        [HttpPost]
        
        public ActionResult Create(Inquilino inquilino)
        {

            try
            {
                // TODO: Add insert logic here
                int res = repositorio.Alta(inquilino);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
             
            }
        }

        // GET: Inquilino/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var e = repositorio.ObtenerPorId(id);
                return View(e);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        // POST: Inquilino/Edit/5
        [HttpPost]
        
        public ActionResult Edit(int id, Inquilino e)
        {
            try
            {
                // TODO: Add insert logic here
                int res = repositorio.Modificacion(e);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        // GET: Inquilino/Delete/5
        [Authorize(Policy = "Administrador")]
        public ActionResult Delete(int id)
        {
            try
            {
                var e = repositorio.ObtenerPorId(id);
                return View(e);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        // POST: Inquilino/Delete/5
        [HttpPost]
        [Authorize(Policy = "Administrador")]
        public ActionResult Delete(int id, Inquilino e)
        {
            try
            {
                int res = repositorio.Baja(id);
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