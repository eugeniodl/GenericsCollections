using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaLINQ
{
    public class ControlEmpresasEmpleados
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
                    Nombre = "Félix Ruiz",
                    Cargo = "CEO",
                    Salario = 10000,
                    EmpresaId = 1,
                },
                new Empleado()
                {
                    Id = 2,
                    Nombre = "Pedro Reyes",
                    Cargo = "CEO",
                    Salario = 5000,
                    EmpresaId = 2,
                },
                new Empleado()
                {
                    Id = 3,
                    Nombre = "Ramón Cárdenas",
                    Cargo = "Analista Programador",
                    Salario = 7000,
                    EmpresaId = 1,
                },
                new Empleado()
                {
                    Id = 4,
                    Nombre = "Lizamara Pérez",
                    Cargo = "Asistente",
                    Salario = 600,
                    EmpresaId = 2,
                },
                new Empleado()
                {
                    Id = 5,
                    Nombre = "Tiffany Urroz",
                    Cargo = "Asistente",
                    Salario = 500,
                    EmpresaId = 2,
                },
            };
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return (from empleado in listaEmpleados
                   select empleado).ToList();
        }

        public void ObtenerEmpresa(string nombreEmpresa)
        {
            var queryEmpresa = from empleado in listaEmpleados
                               join empresa in listaEmpresas
                               on empleado.EmpresaId equals
                               empresa.Id
                               where empresa.Nombre == nombreEmpresa
                               select empleado;
            foreach (var empleado in queryEmpresa)
            {
                Console.WriteLine(empleado);
            }
        }

        public void ObtenerCargo(string cargo)
        {
            var queryCargo = (from empleado in listaEmpleados
                             where empleado.Cargo == cargo
                             select empleado).ToList();
            queryCargo.ForEach(e => Console.WriteLine(e));
        }

        public void ObtenerSalario(double salario)
        {
            var querySalario = (from empleado in listaEmpleados
                                orderby empleado.Salario descending
                               where empleado.Salario > salario
                               select empleado).ToList();
            querySalario.ForEach(e => Console.WriteLine(e));
        }


    }
}
