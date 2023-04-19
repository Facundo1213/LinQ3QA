using EjemplosWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosWin
{
    internal class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public int Salario { get; set; }
        public int EmpresaId { get; set; }
        public string Estado { get; set; }
        public static IList<Empleado> empreados = new List<Empleado>
        {
            new Empleado { Id = 7, Nombre = "Carmen", Cargo = "Desarrollador", EmpresaId = 4, Salario = 4000 , Estado = "Ausente" },
            new Empleado { Id = 7, Nombre = "Carmen", Cargo = "CEO", EmpresaId = 5, Salario = 6000 , Estado = "Trabajando" },
            new Empleado { Id = 8, Nombre = "Ana", Cargo = "Desarrollador", EmpresaId = 4, Salario = 5000 , Estado = "Ausente" },
            new Empleado { Id = 8, Nombre = "Ana", Cargo = "CEO", EmpresaId = 6, Salario = 4000, Estado = "Trabajando" },
            new Empleado { Id = 9, Nombre = "Carlos", Cargo = "Desarrollador", EmpresaId = 6, Salario = 6000, Estado = "Trabajando" },
            new Empleado { Id = 9, Nombre = "Carlos", Cargo = "Desarrollador", EmpresaId = 5, Salario = 4000, Estado = "Ausente" },
            new Empleado { Id = 1, Nombre = "Gonzalo", Cargo = "CEO", EmpresaId = 4, Salario = 6000, Estado = "Trabajando" },
            new Empleado { Id = 9, Nombre = "Carlos", Cargo = "CEO", EmpresaId = 6, Salario = 4000, Estado = "Ausente" }
        };
    }
}
