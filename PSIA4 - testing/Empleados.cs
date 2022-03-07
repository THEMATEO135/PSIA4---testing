using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSIA4___testing
{
    internal class Empleados
    {
        public string emp_nombre;
        public string emp_identificacion;
        public int emp_edad;
        public bool tipoEmpleado;


        public Empleados(string nombre, string identificacion, int edad, bool tipo)
        {
            emp_nombre = nombre;
            emp_identificacion = identificacion;
            emp_edad = edad;
            tipoEmpleado = tipo;
        }

    }
}
