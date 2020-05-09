using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
	public interface IRepositorioUsuario : IRepositorio<Usuario>
	{
		Usuario ObtenerPorEmail(string email);
    }
}
