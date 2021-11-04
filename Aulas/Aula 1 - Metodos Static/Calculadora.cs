/*
*	<copyright file="Aula1.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>9/29/2021 9:14:52 PM</date>
*	<description>
*	Calculadora simples
*	Aula de LP2 -
*	</description>
**/

using System;

namespace Aula1
{
    /// <summary>
    /// Classe que suporta...
    /// </summary>
    class Calculadora
    {
        /// <summary>
        /// Método principal...
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            //int[] v = new int[4];
            //v[0] = 23;
            //v[1] = int.Parse(Console.ReadLine());

            //int maior = Calculo.Maior(v);

            int r = Calculo.Soma(2, 3);
            Console.WriteLine("Soma = {0}", r);

            Console.ReadKey();
        }
    }
}
