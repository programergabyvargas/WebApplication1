using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Contrato
    {
        
        public int IdContrato { get; set; }
        //[Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime FechaInicio { get; set; }
        //[Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime FechaFin { get; set; }
        [Required]
        public int MontoMensual { get; set; }
        public int IdInmueble { get; set; }
        [ForeignKey("IdInmueble")]
        public Inmueble PropiedadAlquilada { get; set; }
        
        public int IdInquilino { get; set; }
        [ForeignKey("IdInquilino")]
        public Inquilino Locatario { get; set; }

    }
}
