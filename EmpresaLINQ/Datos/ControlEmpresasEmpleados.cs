using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaLINQ
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
                    Nombre = "Hermoso y Vigil, S.A.",
                },
                new Empresa()
                {
                    Id = 2,
                    Nombre = "GBM Nicaragua",
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
