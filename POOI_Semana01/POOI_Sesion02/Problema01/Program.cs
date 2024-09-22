using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Romina", "Gutierrez", "77001001", "Femenino");
            Empleado empleado = new Empleado("Rosa", "Roman", "77001002", "Femenino", "Completo", 1400);
            Cliente cliente = new Cliente("Miriam", "Perez", "77001003", "Femenino", "VIP", "1000");


            Console.WriteLine("Nombre : " + persona.nombres);
            Console.WriteLine("Nombre : " + persona.nombres + " - Apellidos : " + persona.apellidos);
            Console.WriteLine($"Nombre: {persona.nombres} - Apellidos : {persona.apellidos}");

            Console.WriteLine("Nombre Completo : {0} {1} ", persona.nombres, persona.apellidos);
            Console.WriteLine("Nombre Completo : {1} {0} ", persona.nombres, persona.apellidos);
           


            Console.ReadKey();


        }
    }
}
