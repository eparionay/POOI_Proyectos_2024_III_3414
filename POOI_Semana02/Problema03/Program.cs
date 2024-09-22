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
            List<Empleado> lista = new List<Empleado>();

            Empleado empleado1 = new Empleado(2, "Rosa", 150);

            lista.Add(new Empleado()
            {
                codigo = 1, nombres = "Juana", sueldo = 100
            });
            lista.Add(empleado1);
            lista.Add(new Empleado(3, "Mercedes", 80));
            lista.Add(new Empleado(4, "Luisa", 250));
            imprimir(lista);
            Console.WriteLine("**********************");
            List<Empleado> lista1 = lista.OrderBy(x => x.nombres).ToList();
            imprimir(lista1);
            Console.WriteLine("**********************");
            List<Empleado> lista2 = lista.OrderByDescending(x => x.nombres).ToList();
            imprimir(lista2);
            Console.WriteLine("**********************");
            Empleado objEmpBuscar = lista.Where(x => x.codigo == 2).First();
            Console.WriteLine("Empleado : " +objEmpBuscar.codigo);
            Console.WriteLine("**********************");
            List<Empleado> listaBuscarEmp = lista.Where(x=> x.sueldo > 200).ToList();
            imprimir(listaBuscarEmp);
            Console.WriteLine("**********************");
            int indice = lista.FindIndex(x=> x.codigo==4);
            Console.WriteLine("Indice : " +  indice);
            Console.WriteLine("**********************");
            lista.RemoveAt(indice);
            imprimir(lista);
            Console.WriteLine("**********************");




            Console.ReadKey();    

        }
        public static void imprimir(List<Empleado> lista)
        {
            foreach (Empleado x in lista)
            {
                Console.WriteLine(x.codigo + "-" + x.nombres + "-" + x.sueldo);
            }
        }
    }
}
