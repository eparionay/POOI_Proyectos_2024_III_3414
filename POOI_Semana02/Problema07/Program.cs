using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("c:/log/loga.txt"))
            {
                Console.WriteLine("Existe");
            }
            else
            {
                FileStream archivoCreado = File.Create("c:/log/loga.txt");
                archivoCreado.Close();
                Console.WriteLine("No existe");
                Console.WriteLine("Se crea archivo ......");
            }
          
            DateTime fecha = DateTime.Now;
         
            string rutaDestinoBackup = "C:/log/Backup/loga" + fecha.ToString("yyyyMMdd_HHmmss") + ".txt";
            string rutaDestinoEnviados = "C:/log/Enviados/loga" + fecha.ToString("yyyyMMdd_HHmmss") + ".txt";



            File.Move("c:/log/loga.txt", rutaDestinoBackup);
            Console.ReadKey();


        }
    }
}
