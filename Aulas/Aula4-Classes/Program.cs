using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Pessoa p = new Pessoa("ola", 12);
            Pessoa p1 = new Pessoa("ola", 12);

            //Pessoa.TotProjetos = 12;
            Console.WriteLine("Total de Objetos:" + Pessoa.TotObjetos.ToString());

            Turma t1 = new Turma(40);
            bool aux = t1.ExisteAluno("joão");

            //Turmas turs = new Turmas();

            Turmas.ExisteTurma(1, "ola");

            

            Console.ReadKey();
        }
    }
}
