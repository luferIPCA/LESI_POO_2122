/*
*	<copyright file="ResolucaoTeste2020_21.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/22/2021 9:29:40 PM</date>
*	<description></description>
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucaoTeste2020_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //a)
            Pessoa p = new Pessoa();

    
            p.NC = 123456789;
            p.DN = new DateTime(2021, 12, 12);
            long dia = p.DiaDaSemana();
            Console.WriteLine("Nasceu no dia {0}\n", dia);

            Console.WriteLine("Vive há {0} dias\n", p.GetDiasVida());
        }
    }
}
