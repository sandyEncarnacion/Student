using System;
using System.Collections.Generic;

namespace StudentReg.Models
{
    public partial class Estudiantes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Carrera { get; set; }
        public string Estado { get; set; }
    }
}
