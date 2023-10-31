using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaLINQ.Logica
{
    public class Empleado
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Cargo { get; set;}
        public double Salario { get; set; }
        public int EmpresaID { get; set; }

        public override string ToString()
        {
            return string.Format($"Empleado {Name} con ID = {ID}, " +
                $"cargo {Cargo}, salario {Salario} pertenece a la " +
                $"empresa {EmpresaID}");
        }
    }
}
