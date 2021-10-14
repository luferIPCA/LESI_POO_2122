/*
*	<copyright file="Aula3___Classes.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/13/2021 9:38:30 PM</date>
*	<description></description>
**/
using System;
using System.Diagnostics;   //Garbage Collection
using System.Threading;     //Threads

namespace Aula3___Classes
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/13/2021 9:38:30 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Carro
    {


        #region Attributes
        public static int tot;

        int ano;
        string matricula;
        #endregion      //Estado

        #region Methods //Comportamento

        #region Constructors

        /// <summary>
        /// Cria uma instância de carro com ano igual ao ano corrente
        /// </summary>
        public Carro()
        {
            ano = DateTime.Today.Year;
            matricula = "00-00-00";
            tot++;
        }

        /// <summary>
        /// Cria uma carro com ano inserido
        /// </summary>
        /// <param name="ano">Ano do Carro</param>
        /// <param name="mat">Matricula do carro</param>
        public Carro(int ano, string mat)
        {
            this.ano = ano;
            matricula = mat;
            tot++;
        }

        public Carro(string data, string mat)
        {
            //DateTime d = DateTime.Parse(data);
            ano = DateTime.Parse(data).Year;
            matricula = mat;
            tot++;
        }

        public Carro(string data)
        {
            ano = DateTime.Parse(data).Year;
            matricula = "";
            tot++;
        }


        #endregion

        #region Properties

        #region A la JAVA
        public int GetAno()
        {
            return ano;
        }

        public bool SetAno(int ano)
        {
            if (ano <= 0) return false;
            //Se o ano é válido
            this.ano = ano;
            return true;
        }
        #endregion

        public int Ano
        {
            get
            {
                return ano;
            }
            set
            {
                if (ano >= 0)
                    ano = value;
            }
        }

        #endregion


        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Soma dois valores
        /// </summary>
        /// <param name="x">Valor 1</param>
        /// <param name="y">Valor 2</param>
        /// <returns></returns>
        public int Soma(int x, int y)
        {
            return 0;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Carro()
        {
            //Encerrar um ficheiro
            //Registar log
            Console.WriteLine("Memoria recuperada!");
        }
        #endregion

        #endregion      //Comport
    }

    /// <summary>
    /// Adaptado de
    /// https://docs.microsoft.com/en-us/dotnet/api/system.object.finalize?view=net-5.0#examples
    /// </summary>
    public class ExampleClass
    {
        Stopwatch sw;

        public ExampleClass()
        {
            sw = Stopwatch.StartNew();
            Console.WriteLine("Instantiated object");
            Thread.Sleep(1000);     //força delay de 1s
        }

        public void ShowDuration()
        {
            Console.WriteLine("This instance of {0} has been in existence for {1}",
                              this, sw.Elapsed);
        }

        ~ExampleClass()
        {
            Console.WriteLine("Finalizing object");
            sw.Stop();
            Console.WriteLine("This instance of {0} has been in existence for {1}",
                              this, sw.Elapsed);
        }
    }

}
