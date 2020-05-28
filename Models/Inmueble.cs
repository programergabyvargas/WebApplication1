using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Models
{
	public class Inmueble
	{
		[Key]
		[Display(Name = "Código")]
        public int IdInmueble { get; set; }
		[Required]
		public string Direccion { get; set; }
		[Required]
		public int Ambientes { get; set; }
		[Required]
		public int Superficie { get; set; }
		public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
        [Display(Name = "Dueño")]
        public int IdPropietario { get; set; }
        [ForeignKey("IdPropietario")]
        public Propietario Duenio { get; set; }
		[Required]
		public bool Disponible { get; set; }
	}
}
