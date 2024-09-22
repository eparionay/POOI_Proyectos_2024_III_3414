using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Docente objDocente = new Docente();
            //objDocente.codigo = 1;
            objDocente.nombre = "Romina";
            objDocente.tarifa = 10;
            objDocente.horas = 100;
            Console.WriteLine("Codigo : " + objDocente.codigo);
            Console.WriteLine("Nombre : " + objDocente.nombre);
            Console.WriteLine("Horas  : " + objDocente.horas);
            Console.WriteLine("Sueldro Bruto : " + objDocente.getSueldoBruto());
            Console.WriteLine("**********************************");
            Docente objDocente1 = new Docente(105);
            Console.WriteLine(objDocente1.codigo);
            Console.WriteLine("**********************************");
            Docente objDocente2= new Docente("Juana");
            Console.WriteLine(objDocente2.nombre);
            Console.WriteLine("**********************************");
            Docente objDocente3 = new Docente(101, "Raquel", 10, 23);
            Console.WriteLine(objDocente3.codigo);
            Console.WriteLine(objDocente3.getSueldoBruto());
            Console.WriteLine(objDocente3.getDescuento());
            Console.WriteLine(objDocente3.getSueldoNeto());

            Console.ReadKey();


        }
    }
}
