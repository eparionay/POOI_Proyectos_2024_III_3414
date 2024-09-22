using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema02
{
    internal class Filmacion
    {

        public int codigo { get; set; }
        public string titulo { get; set; }  
        public int minutos { get; set; }
        public double precioSoles { get; set; }

        public double getPrecioDolar()
        {
            return precioSoles / 3.59;
        }


    }
}
