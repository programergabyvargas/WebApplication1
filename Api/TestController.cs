using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Api
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private readonly DataContext contexto;
        //private readonly Propietario propietario;
        public TestController(DataContext context)
        {
            this.contexto = context;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Propietario>>> Get()
        {

            return contexto.Propietarios;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult<Propietario> Get(int id)
        {
            if (id <= 0)
                return NotFound();
            
                var res = contexto.Propietarios.FirstOrDefault(x => x.IdPropietario == id);
            if (res != null)
                return res;
            else
                return NotFound();
                    
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
