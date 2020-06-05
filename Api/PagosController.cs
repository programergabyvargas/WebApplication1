using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication1.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.api
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PagosController : Controller
    {
        private readonly DataContext contexto;
        private readonly IConfiguration config;

        public PagosController(DataContext contexto, IConfiguration config)
        {
            this.contexto = contexto;
            this.config = config;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pago>>> Get()
        {
             try
             {
              //var usuario = User.Identity.Name;
             return Ok(contexto.Pagos.Include(e => e.ContratoAsociado));
            return contexto.Pagos;
              }
              catch (Exception ex)
               {
                 return BadRequest(ex);
              }
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                return Ok(contexto.Pagos.SingleOrDefault(x => x.IdPago == id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(Pago entidad)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contexto.Pagos.Add(entidad);
                    contexto.SaveChanges();
                    return CreatedAtAction(nameof(Get), new { id = entidad.IdPago }, entidad);
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
        public void Put(int id, [FromBody]string value)
        {
            //contexto.Pagos.Update()
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // GET: api/<controller>
        [HttpGet("test")]
        [AllowAnonymous]
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
