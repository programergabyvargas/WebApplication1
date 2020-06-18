using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.api
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class InmueblesController : Controller
    {
        private readonly DataContext contexto;

        public InmueblesController(DataContext contexto)
        {
            this.contexto = contexto;
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var usuario = User.Identity.Name;
                return Ok(contexto.Inmuebles.Where(e => e.Duenio.Email == usuario));

                //return Ok(contexto.Inmuebles.Include(e => e.Duenio));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /*  public async Task<IActionResult> Get()
          {
              try
              {
                  var usuario = User.Identity.Name;
                  return Ok(contexto.Inmuebles.Include(e => e.Duenio).Where(e => e.Duenio.Email == usuario));
              }
              catch (Exception ex)
              {
                  return BadRequest(ex);
              }
          }*/


        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var usuario = User.Identity.Name;
               // return Ok(contexto.Inmuebles.Include(e => e.Duenio).Where(e => e.Duenio.Email == usuario).Single(e => e.IdInmueble == id));
                return Ok(contexto.Inmuebles.Single(e => e.IdInmueble == id));
              //return Ok(contexto.Inmuebles.SingleOrDefault(x => x.IdInmueble == id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(Inmueble entidad)
        {
            try
            {   
                if (ModelState.IsValid)
                {
                    entidad.IdPropietario = contexto.Propietarios.AsNoTracking().Single(e => e.Email == User.Identity.Name).IdPropietario;
                    entidad.Duenio = null; // Agregue null a duenio
                    contexto.Inmuebles.Add(entidad);
                    contexto.SaveChanges();
                    return CreatedAtAction(nameof(Get), new { id = entidad.IdInmueble }, entidad);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Inmueble entidad)
        {
            try
            {
                Inmueble inmueble = null;
               //var usuario = User.Identity.Name;
                if (ModelState.IsValid)
                {
                    if (contexto.Inmuebles.AsNoTracking().Include(e => e.Duenio).FirstOrDefault(e => e.IdInmueble == id && e.Duenio.Email == User.Identity.Name) != null) {
                        inmueble = contexto.Inmuebles.SingleOrDefault(x => x.IdInmueble == id);
                        //inmueble.IdInmueble = id;
                        inmueble.Direccion = entidad.Direccion;
                        inmueble.Ambientes = entidad.Ambientes;
                        inmueble.Latitud = entidad.Latitud;
                        inmueble.Longitud = entidad.Longitud;
                        inmueble.Tipo = entidad.Tipo;
                        inmueble.Uso = entidad.Uso;
                        inmueble.Superficie = entidad.Superficie;
                        inmueble.Precio = entidad.Precio;
                        inmueble.Disponible = entidad.Disponible;

                        contexto.Inmuebles.Update(inmueble);
                        contexto.SaveChanges();
                        return Ok(inmueble);
                    }
                    return BadRequest(ModelState +"------");
                }
                return BadRequest(ModelState);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var entidad = contexto.Inmuebles.Include(e => e.Duenio).FirstOrDefault(e => e.IdInmueble == id && e.Duenio.Email == User.Identity.Name);
                if (entidad != null)
                {
                    contexto.Inmuebles.Remove(entidad);
                    contexto.SaveChanges();
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
		}

		// DELETE api/<controller>/5
		[HttpDelete("BajaLogica/{id}")]
		public async Task<IActionResult> BajaLogica(int id)
		{
			try
			{
				var entidad = contexto.Inmuebles.Include(e => e.Duenio).FirstOrDefault(e => e.IdInmueble == id && e.Duenio.Email == User.Identity.Name);
				if (entidad != null)
				{
					entidad.Superficie = -1;//cambiar por estado = 0
					contexto.Inmuebles.Update(entidad);
					contexto.SaveChanges();
					return Ok();
				}
				return BadRequest();
			}
			catch (Exception ex)
			{
				return BadRequest(ex);
			}
		}

        public async Task<IActionResult> Test()
        {
            try
            {
                return Ok("anduvogfhfghf");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
