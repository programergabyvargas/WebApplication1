using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
	public interface IRepositorioPago : IRepositorio<Pago>
	{
		Pago ObtenerPorNumeroDePago(int numeroPago);
        IList<Pago> BuscarPorContrato(int idContrato);
    }
}
