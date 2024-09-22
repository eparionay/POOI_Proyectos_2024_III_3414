using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo01
{
    internal class Docente
    {

        public int codigo { get; set; }
        public string nombre { get; set; }
        public int horas { get; set; }  
        public double tarifa { get; set; }
        public Docente()
        {

        }

        public Docente(int codigo)
        {
            this.codigo = codigo;
        }
        public Docente(string nombre)
        {
            this.nombre = nombre;
        }

        public Docente(int codigo, string nombre, int horas, double tarifa)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horas = horas;
            this.tarifa = tarifa;
        }


        public double getSueldoBruto()
        {
            return horas * tarifa;
        }

        public double getDescuento()
        {
            double sueldoBruto = getSueldoBruto();
            if (sueldoBruto < 4500)
            {
                return sueldoBruto * 0.12;
            }else if (sueldoBruto< 6500)
            {
                return sueldoBruto * 0.14;
            }
            else
            {
                return sueldoBruto * 0.16;
            }
        }
        public double getSueldoNeto()
        {
            return getSueldoBruto() - getDescuento(); 
        }





    }
}
