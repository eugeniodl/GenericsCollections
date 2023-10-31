using PruebaLINQ.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLINQ.Datos
{
    public class ControlEmpleadoEmpresa
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
                new Empleado() { ID = 1, Name= "Julio Mendoza", 
                    Cargo="CEO", Salario = 5000, EmpresaID = 1 },
                new Empleado() { ID = 2, Name= "Sonia López",
                    Cargo="Asistente", Salario = 500, EmpresaID = 1 },
                new Empleado() { ID = 3, Name= "Karen Fonseca",
                    Cargo="CEO", Salario = 3000, EmpresaID = 2 },
                new Empleado() { ID = 4, Name= "Luis Soto",
                    Cargo="Programador", Salario = 7500, EmpresaID = 3 },
                new Empleado() { ID = 5, Name= "Mario Gómez",
                    Cargo="Soporte Técnico", Salario = 3000, EmpresaID = 4 },
                new Empleado() { ID = 6, Name= "Sergio Robleto",
                    Cargo="Contador", Salario = 500, EmpresaID = 5 },
            };
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return (from empleado in listaEmpleados
                    select empleado
                ).ToList();
        }

        // Obtener cargo
        public void ObtenerCargo(string cargo)
        {
            if (cargo != null)
            {
                var queryCEO = (from empleado in listaEmpleados
                                where empleado.Cargo == cargo
                                select empleado).ToList();
                queryCEO.ForEach(e => Console.WriteLine(e));
            }
        }

        // Obtener los empleados con salario mayor que un dato
        public void ObtenerSalario(double salario)
        {
            var querySalario = from empleado in listaEmpleados
                            orderby empleado.Salario descending
                            where empleado.Salario > salario
                            select empleado;
            foreach (var empleado in querySalario)
            {
                Console.WriteLine(empleado);
            }
        }

        public void ObtenerEmpleadosEmpresa(string nombreEmpresa)
        {
            var queryEmpresa = (from empleado in listaEmpleados
                               join empresa in listaEmpresas
                               on empleado.EmpresaID equals
                               empresa.ID
                               where empresa.Name == nombreEmpresa
                               select empleado).ToList();
            queryEmpresa.ForEach(empleado => Console.WriteLine(empleado));
        }
    }
}
