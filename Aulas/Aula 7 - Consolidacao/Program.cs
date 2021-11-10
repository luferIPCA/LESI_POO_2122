using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_7___Consolidacao
{
    class Program
    {
        static void Main(string[] args)
        {

            Imobiliario i = new Imobiliario();

            i.CodImobiliario = 2;       //set
            //int x = i.CodImobiliario;   //get não é permitido!!!


            Imobiliario i2 = new Imobiliario(Tipo.BAIRRO, DateTime.Now.AddDays(5));

            Predio p = new Predio(Tipo.CASA, DateTime.Now, "Rua..");

            p.GetAnoConst();
            p.GetDiasConstrucao();

            Bairro b = new Bairro();
            b.GetAnoConst();
            b.GetCodImobiliario();
            b.GetDiasConstrucao();

            TestaInterface.GetAno(b);
            TestaInterface.GetAno(p);

        }
    }
}
