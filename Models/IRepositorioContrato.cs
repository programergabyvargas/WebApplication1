using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
	public interface IRepositorioContrato : IRepositorio<Contrato>
	{
		IList<Contrato> BuscarPorInmueble(int idInmueble);
		IList<Contrato> BuscarPorInquilino(int idInquilino);
	}
}
