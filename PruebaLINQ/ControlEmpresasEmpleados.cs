using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLINQ
{
    internal class ControlEmpresasEmpleados
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public ControlEmpresasEmpleados()
        {
            listaEmpresas = new List<Empresa>{
                new Empresa()
                {
                    Id = 1,
                    Nombre = "",
                },
            };

            listaEmpleados = new List<Empleado>()
            {
                new Empleado()
                {
                    Id = 1,
                    Nombre = "",
                    Cargo = "",
                    Salario = 0,
                    EmpresaId = 1,
                }
            };
        }


    }
}
