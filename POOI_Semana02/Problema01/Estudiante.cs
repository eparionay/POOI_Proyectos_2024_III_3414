using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema01
{
    internal class Estudiante
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string genero { get; set; }

        public Estudiante()
        {

        }

        public Estudiante(int codigo, string nombre, string apellido, string genero)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.genero = genero;
        }
    }
}
