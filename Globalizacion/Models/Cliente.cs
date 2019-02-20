using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Globalizacion.Models
{
    public class Cliente
    {
        [Required]
        public String Nombre { get; set; }
        [Required]
        public String Apellido { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public String Direccion { get; set; }
        [Required]
        public int CP { get; set; }
        [Required]
        public int Contribucion { get; set; }
        public String Comentario { get; set; }
    }
}