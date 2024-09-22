using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Filmacion x = new Filmacion();
            x.codigo = 1;
            x.titulo = "Alien Romulus";
            x.minutos = 120;
            x.precioSoles = 100;

            Console.WriteLine("Precio en $ : "+ x.getPrecioDolar());
            Console.ReadKey();

        }
    }
}
