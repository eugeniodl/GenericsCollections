using PruebaLINQ.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLINQ.Datos
{
    internal class ControlEmpleadoEmpresa
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public ControlEmpleadoEmpresa()
        {
            listaEmpresas = new List<Empresa>()
            {
                new Empresa() { ID = 1, Name = "SPC INTERNACIONAL" },
                new Empresa() { ID = 2, Name = "SERINICSA" },
                new Empresa() { ID = 3, Name = "INTELLIGENT SOLUTIONS, S.A." },
                new Empresa() { ID = 4, Name = "CONDOR COMUNICACIONES, S.A." },
                new Empresa() { ID = 5, Name = "AMNET" },
            };
            listaEmpleados = new List<Empleado>()
            {
            };
        }
    }
}
