using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CineHitss.Models
{
    public class UsuarioMdl
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        public float Puntos { get; set; }
    }
}