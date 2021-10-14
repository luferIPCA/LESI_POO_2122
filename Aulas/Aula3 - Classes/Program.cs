/*
*	<copyright file="Aula3___Classes.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/13/2021 9:38:30 PM</date>
*	<description>
*	Inclui Garbage Collection (Adaptado de:https://qawithexperts.com/article/c-sharp/understanding-garbage-collection-in-c/179)
*	</description>
**/


using System;

namespace Aula3___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;      //tipo valor

            //Carro c;    //tipo referência
            //c = new Carro();

            Carro c = new Carro();
            Console.WriteLine("Ano:" + c.GetAno().ToString());

            Carro c2 = new Carro(2022,"00-00-01");
            Carro c5 = new Carro("12-10-2021", "12-12-12");

            bool aux = c5.SetAno(-12);

            Console.WriteLine("Ano:" + c.Ano.ToString());
            c.Ano = 2000;

            Console.WriteLine("Existem:" + Carro.tot.ToString());

            #region Garbage Collection
            //Forçar o Destructor
            c = null;

            GC.Collect();   //mas evitar usar...o compilador faz muito melhor!!!

            ExampleClass ex = new ExampleClass();
            ex.ShowDuration();

            #endregion

            Console.ReadKey();
        }
    }
}
