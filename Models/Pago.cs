using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Pago
    {
		[Key]
		[Display(Name = "Código")]
		public int IdPago { get; set; }
		[Required]
		public int NroPago { get; set; }
		[Required]
		public DateTime FechaPago { get; set; }
		[Required]
		public int Importe { get; set; }
		public int IdContrato { get; set; }
		[Required, EmailAddress]
		public Contrato ContratoAsociado { get; set; }
		}
}
