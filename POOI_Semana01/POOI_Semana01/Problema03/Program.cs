using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Docente x = new Docente();
            x.nombre = "Erick";

            x.saludar();
            Console.ReadKey();

        }
    }
}
