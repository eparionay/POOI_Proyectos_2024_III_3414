using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema01
{
    internal class Cliente : Persona
    {
        public Cliente(string nombres, string apellidos,
            string documento, string genero, string categoria, string codigo) : base(nombres, apellidos, documento, genero)
        {
            this.categoria= categoria; 
            this.codigo= codigo;    
        }

        public string categoria { get; set; }
        public string codigo { get; set; }

        public string generarCodigo()
        {
            return codigo;  
        }



    }
}
