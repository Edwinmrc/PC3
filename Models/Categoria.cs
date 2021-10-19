using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PC3.Models
{
    public class Categoria
    {
        public int Id {get; set;}
        
        [Required]
        public string Nombre { get; set; }
        
        [Required]   

        public ICollection<Solicitud> Solicitudes {get; set;}

    }
}