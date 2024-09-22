using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problema01
{
    internal class Program
    {
        private static readonly ILog LOG = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {

            LOG.Info("Inicio de Aplicativo");

            Stopwatch temporizador = new Stopwatch();
            temporizador.Start();
            Console.WriteLine("Inicio de Programa ................");
            try
            {
                int contador = 0;
                int resultado = 0;
                int numero = 10;
                while (contador < 10)
                {
                   
                    resultado = numero  / contador;
                    LOG.Info("Numero : " + contador + "- Resultado : " + resultado);
                    Thread.Sleep(1000);
                    contador++;
                }
                
                

            }catch(Exception ex) {
                //Console.WriteLine(ex.GetType().Name);
                //Console.WriteLine(ex.TargetSite);
                LOG.Error("Error : " + ex.Message);
                registrarMensajeError($"{getFechaActual()} - Error : {ex.Message}");
            }
            Console.WriteLine("Fin de Programa ................");
            temporizador.Stop();
            Console.WriteLine(temporizador.Elapsed);
            Console.ReadKey();
        }
        public static void registrarMensajeError(string mensaje)
        {
            string ruta = ConfigurationManager.AppSettings["ruta_archivo"].ToString();
            StreamWriter escritor = null;
            try
            {
                escritor = new StreamWriter(ruta, true);
                escritor.WriteLine(mensaje);
            }
            catch (Exception ex)
            {
                LOG.Error("registrarMensajeError - Error : " + ex.Message);
            }
            finally
            {
                escritor.Close();
            }
        }
        public static string getFechaActual()
        {
            DateTime fecha = DateTime.Now;
            return fecha.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }

    }
}
