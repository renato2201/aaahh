using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pc3.Models
{
    public class Prueba
    {   
        [Required]
        public int Id { get; set; }

        [Required]
        public string NombreProducto { get; set; }

        [Required]
        public string Foto { get; set; }

        [Required]
        public string Descripcion{ get; set;}
        
        [Required]
        public float Precio { get; set; }

        [Required]
        public string Celular{ get; set;}

        [Required]
        public string Lugar { get; set;}

        [Required]
        public string Nombre{ get; set;}

        [Required]
        public string Categoria{ get; set;}



    }
}