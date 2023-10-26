using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaLINQ
{
    internal class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return string.Format($"Empresa {Nombre} con {Id}");
        }
    }
}
