using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numerador = 10;
            int denominador = 0;
            try
            {
                //int resultado = numerador / denominador;
                //Console.WriteLine(resultado);

                int saldo = 0;

                if (saldo == 0)
                {
                    throw new SaldoInsuficienteException("No puede ser el saldo 0");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.GetType().Name);
            }
            Console.ReadKey();






        }
    }
}
