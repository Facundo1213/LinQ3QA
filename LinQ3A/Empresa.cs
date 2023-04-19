using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosWin
{
    internal class Empresa
    {
        
        public int Id { get; set; }
        public string Nombre { get; set; }

        public static IList<Empresa> Empre= new List<Empresa>
        {
            new Empresa { Id = 4, Nombre = "OmegaO" },
            new Empresa { Id = 5, Nombre = "BetaB" },
            new Empresa { Id = 6, Nombre = "GammaF" }
        };

    }
}
