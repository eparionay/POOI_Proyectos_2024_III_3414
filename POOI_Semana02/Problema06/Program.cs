using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directorio = new DirectoryInfo("D:/log");

            DirectoryInfo [] directorios = directorio.GetDirectories();

            foreach (DirectoryInfo director in directorios)
            {
                Console.WriteLine(director.FullName);
                FileInfo[] archivos = director.GetFiles();
                foreach (FileInfo archivo in archivos)
                {
                    Console.WriteLine("Nombre Archivo : " + archivo.Name);
                    Console.WriteLine("Extension Archivo : " + archivo.Extension);
                }
                Console.WriteLine("*****************");
            }


            Console.ReadKey();
        }
    }
}
