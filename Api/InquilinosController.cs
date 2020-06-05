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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.api
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class InquilinosController : Controller
    {
        private readonly DataContext contexto;
        private readonly IConfiguration config;

        public InquilinosController(DataContext contexto, IConfiguration config)
        {
            this.contexto = contexto;
            this.config = config;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inquilino>>> Get()
        {
            return contexto.Inquilinos;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                return Ok(contexto.Inquilinos.SingleOrDefault(x => x.IdInquilino == id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // GET api/<controller>/5
     

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(Inquilino entidad)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contexto.Inquilinos.Add(entidad);
                    contexto.SaveChanges();
                    return CreatedAtAction(nameof(Get), new { id = entidad.IdInquilino }, entidad);
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
            //contexto.Propietarios.Update()
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
