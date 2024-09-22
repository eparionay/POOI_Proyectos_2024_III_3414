using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = ConfigurationManager.
                AppSettings["ruta"].ToString();
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(ruta);
                string texto = reader.ReadToEnd();
                Console.WriteLine("Texto : " + texto);

                /*
                string linea =reader.ReadLine();
                while (linea != null)
                {
                    Console.WriteLine(linea); 
                    linea = reader.ReadLine();
                }
                */
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error : " + ex.ToString());
            }
            finally
            {
                reader.Close();
            }
            Console.ReadKey();

        }
    }
}
