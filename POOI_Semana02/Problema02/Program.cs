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
            // Clase Empleado
            //List<Empleado> lista = new List<Empleado>();
            List<int> lista = new List<int>();
            lista.Add(10);
            lista.Add(2);
            lista.Add(30);
            lista.Add(14);
            lista.Add(25);
            lista.Add(23);
            lista.Add(18);
            lista.Add(14);
            imprimirArreglo(lista);
            Console.WriteLine("¨************************************");
            
            int contar = lista.Count;
            Console.WriteLine("Total de Elementos : " + contar);
            Console.WriteLine("¨************************************");
            lista.Sort();
            imprimirArreglo(lista);
            Console.WriteLine("****************************");
            lista.Reverse();
            imprimirArreglo(lista);
            lista.Remove(14);
            imprimirArreglo(lista);
            lista.RemoveAt(1);
            imprimirArreglo(lista);
            lista.RemoveAll(y => y == 14 || y==25 );
            imprimirArreglo(lista);
            lista.RemoveRange(5, 2);
            imprimirArreglo(lista);
            lista.RemoveAll(x => x % 2 == 0);
            imprimirArreglo(lista);
            
            int buscarNumero1 = lista.IndexOf(10);
            Console.WriteLine("BuscarNumero 10 (Posicion) : "+ buscarNumero1);
            int buscarNumero2 = lista.IndexOf(30);
            Console.WriteLine("BuscarNumero 30 (Posicion) : " + buscarNumero2);
            int buscarNumero3 = lista.IndexOf(50);
            Console.WriteLine("BuscarNumero 50 (Posicion) : " + buscarNumero3);
            int primerElemento = lista.First();
            Console.WriteLine("Primer Elemento : " + primerElemento);
            int primerElemento1 = lista.FirstOrDefault(x => x == 2);
            Console.WriteLine("primerElemento1: " + primerElemento1);
            int primerElemento2 = lista.FirstOrDefault(x=> x==60 );
            Console.WriteLine("primerElemento2 : " + primerElemento2);
            bool existeElemento1 = lista.Exists(x => x == 2);
            Console.WriteLine("existeElemento 2 : " + existeElemento1);
            bool existeElemento2 = lista.Exists(x => x == 150);
            Console.WriteLine("existeElemento 150 : " + existeElemento2);
            lista.Clear();
            imprimirArreglo(lista);
            Console.ReadKey();
        }

        public static void imprimirArreglo(List<int> lista)
        {
            foreach(int i in lista)
            {
                Console.WriteLine(i);
            }
        }



    }
}
