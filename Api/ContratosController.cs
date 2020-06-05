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
    [Route("api/[controller]")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ContratosController : Controller
    {
        private readonly DataContext contexto;

        public ContratosController(DataContext contexto)
        {
            this.contexto = contexto;
        }

        // GET: api/<controller>
        [HttpGet]
          public async Task<ActionResult<IEnumerable<Contrato>>> Get()
        {
            try
            {
                //  var usuario = User.Identity.Name;
                 return Ok(contexto.Contratos.Include(e => e.PropiedadAlquilada).Include(e => e.Locatario));
                
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
               // return Ok(contexto.Inmuebles.Include(e => e.Duenio).Where(e => e.Duenio.Email == usuario).Single(e => e.IdInmueble == id));
              return Ok(contexto.Contratos.SingleOrDefault(x => x.IdContrato == id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(Contrato entidad)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contexto.Contratos.Add(entidad);
                    contexto.SaveChanges();
                    return CreatedAtAction(nameof(Get), new { id = entidad.IdContrato }, entidad);
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
        public async Task<IActionResult> Put(int id, Contrato entidad)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contexto.Contratos.Add(entidad);
                    contexto.SaveChanges();
                    return CreatedAtAction(nameof(Get), new { id = entidad.IdContrato }, entidad);
                }
                return BadRequest();
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
                return Ok("anduvo");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
