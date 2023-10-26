using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaLINQ
{
    internal class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public int EmpresaId { get; set; }

        public override string ToString()
        {
            return string.Format($"Empleado {Nombre} con " +
                $"{Id}, cargo {Cargo} con salario {Salario} " +
                $"pertenece a la empresa {EmpresaId}");
        }
    }
}
