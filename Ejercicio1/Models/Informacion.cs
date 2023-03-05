using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1.Models
{
   public class Informacion
    {

        int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string edad { get; set; }
        public string correo { get; set; }

        public byte[] foto { get; set; }
    }
}
