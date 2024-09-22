using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema03
{
    internal interface IAlumno
    {
        // registrar
        int registrar(Alumno alumno);
        // eliminar
        int eliminar(int codigo);
        // actualizar
        int actualizar(Alumno alumno);
        // consultar por Id
        Alumno consultarPorId(int codigo);
        // Consultar todo
        List<Alumno> consultarTodo();
    }
}
