using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_III
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa p = new Pessoa();

            Visitante v = new Visitante();
            v.codVisitante = p.codVisitante;
            v.dia = DateTime.Today;


        }
    }
}
