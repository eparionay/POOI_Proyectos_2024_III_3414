using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problema05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StreamReader reader = null;
            try
            {
                
                if (File.Exists("D:/log/loga.txt"))
                {
                    Console.WriteLine("Existe");
                }
                else
                {
                    File.Create("D:/log/loga.txt");
                    Console.WriteLine("No existe");
                    Console.WriteLine("Se crea archivo ......");
                }
                //File.Delete("D:/log/loga.txt");
                DateTime fecha = DateTime.Now;
                string codigo = Guid.NewGuid().ToString();
                Console.WriteLine($"Codigo: {codigo}");

                string rutaDestinoBackup = "D:/log/Backup/loga" + fecha.ToString("yyyyMMdd_HHmmss") + ".txt";
                string rutaDestinoEnviados = "D:/log/Enviados/loga" + fecha.ToString("yyyyMMdd_HHmmss") + ".txt";

                Console.WriteLine("Ruta Destino Backup : "+ rutaDestinoBackup);
                Console.WriteLine("Ruta Destino Enviados : " + rutaDestinoEnviados);
            

                File.Copy("D:/log/loga.txt", rutaDestinoBackup );
                //File.Move("D:/log/loga.txt", rutaDestinoEnviados);

                if (File.Exists("D:/log/loga.txt"))
                {
                    FileInfo archivo = new FileInfo("D:/log/loga.txt");
                    Console.WriteLine("Ruta : " + archivo.FullName);
                    Console.WriteLine("Nombre : " + archivo.Name);
                    Console.WriteLine("Extension : " + archivo.Extension);
                    Console.WriteLine("Tamano : " + archivo.Length);
                    Console.WriteLine("Fecha Creacion : " + archivo.CreationTime);
                }
              
                





                

                /*
                reader = new StreamReader("D:/log/log.txt");
                string texto = reader.ReadToEnd();
                Console.WriteLine(texto);
                */
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.ToString());
            }
            finally
            {
                //reader.Close();

                Console.ReadKey();
            }

            


        }
    }
}
