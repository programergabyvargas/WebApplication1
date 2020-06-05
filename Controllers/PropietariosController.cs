using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApplication1.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Claims;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class PropietariosController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly RepositorioPropietario repositorioPropietario;
        private readonly RepositorioInmueble repositorioInmueble;
       
        public PropietariosController(IConfiguration configuration)
        {
            this.configuration = configuration;
            repositorioPropietario = new RepositorioPropietario(configuration);
            repositorioInmueble = new RepositorioInmueble(configuration);
        }
        // GET: Propietarios
        public ActionResult Index()
        {
            var lista = repositorioPropietario.ObtenerTodos();
            ViewBag.Id = TempData["Id"];
            if (TempData.ContainsKey("Mensaje"))
                ViewBag.Mensaje = TempData["Mensaje"];
            return View(lista);
        }

        // GET: Propietarios/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Propietarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Propietarios/Create
        [HttpPost]
        public ActionResult Create(Propietario propietario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                
                propietario.Clave = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: propietario.Clave,
                salt: System.Text.Encoding.ASCII.GetBytes(configuration["Salt"]),
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 1000,
                numBytesRequested: 256 / 8));
                repositorioPropietario.Alta(propietario);
                TempData["Id"] = propietario.IdPropietario;
                return RedirectToAction(nameof(Index));
                
                }
                else
                    return View(propietario);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.StackTrace = ex.StackTrace;
                return View(propietario);
            }
        }
        

        public async Task<IActionResult> Login(LoginView login)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                        password: login.Clave,
                        salt: System.Text.Encoding.ASCII.GetBytes(configuration["Salt"]),
                        prf: KeyDerivationPrf.HMACSHA1,
                        iterationCount: 1000,
                        numBytesRequested: 256 / 8));

                    var e = repositorioPropietario.ObtenerPorEmail(login.Usuario);
                    if (e == null || e.Clave != hashed)
                    {
                        ModelState.AddModelError("", "El email o la clave no son correctos");
                        return View();
                    }

                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, e.Email),
                        new Claim("FullName", e.Nombre + " " + e.Apellido),
                        //new Claim(ClaimTypes.Role, e.RolNombre),
                    };

                    var claimsIdentity = new ClaimsIdentity(
                        claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity));

                    return RedirectToAction(nameof(Index), "Home");
                }
                return View();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }
        // GET: Propietarios/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var e = repositorioPropietario.ObtenerPorId(id);
                return View(e);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        // POST: Propietarios/Edit/5
        [HttpPost]
        
        public ActionResult Edit(int id, Propietario e)
        {
            try
            {
                // TODO: Add insert logic here
                int res = repositorioPropietario.Modificacion(e);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        // GET: Propietarios/Delete/5
        [Authorize(Policy = "Administrador")]
        public ActionResult Delete(int id)
        {
            try
            {
                var e = repositorioPropietario.ObtenerPorId(id);
                return View(e);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        // POST: Propietarios/Delete/5
        [HttpPost]
        [Authorize(Policy = "Administrador")]
        public ActionResult Delete(int id, Propietario e)
        {
            try
            {
                int res = repositorioPropietario.Baja(id);
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