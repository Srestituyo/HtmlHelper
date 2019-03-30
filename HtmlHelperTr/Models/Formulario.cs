using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace HtmlHelperTr.Models
{
    public class Formulario
    {
        [Required]
        public String Cedula { get; set; }
        [Required]
        public String Nombre { get; set; }
        [Required]
        public String Apellido { get; set; }
        [Required,Range(15,99)]
        public int Edad { get; set; }
        public String Telefono { get; set; }
        [Required,DataType(DataType.EmailAddress),EmailAddress]
        public String Correo { get; set; }
        public String Genero { get; set; }
        public String Estado { get; set; }
        public bool Hobbys { get; set; }

    }



    public enum Gender {
        Masculino,
        Femenino
    }
}