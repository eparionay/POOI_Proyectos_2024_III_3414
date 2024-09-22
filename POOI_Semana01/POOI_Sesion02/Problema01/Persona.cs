using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema01
{
    internal class Persona
    {
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string documento { get; set; }
        public string genero { get; set; }

        public Persona(string nombres, string apellidos, string documento, string genero)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.documento = documento;
            this.genero = genero;
        }

   


    }
}
