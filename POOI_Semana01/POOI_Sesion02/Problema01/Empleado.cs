using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema01
{
    internal class Empleado : Persona
    {
        public Empleado(string nombres, 
            string apellidos, string documento, string genero,
            string tipoContrato, double sueldo) 
            : base(nombres, apellidos, documento, genero)
        {
            this.sueldo = sueldo;
            this.tipoContrato = tipoContrato;
        }

        public string tipoContrato { get; set; }
        public double sueldo { get; set; }

      
        public double calcularSueldo()
        {
            return sueldo;
        }

 



    }
}
