using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class LoginView
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Usuario { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Clave { get; set; }
    }
}
