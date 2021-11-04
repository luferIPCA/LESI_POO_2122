/*
*	<copyright file="Aula_6_Pilares.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/3/2021 9:31:02 PM</date>
*	<description></description>
**/
using System;

namespace Aula_6_Pilares
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/3/2021 9:31:02 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Veiculo
    {
        #region Attributes
        int ano;
        string tipo;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Veiculo()
        {
            Console.WriteLine("- Mais um Veiculo");
        }

        public Veiculo(string n, int a)
        {
            this.ano = ano;
            tipo = n;
        }

        public Veiculo(int ano)
        {
            tipo = "";
            this.ano = ano;
        }

        #endregion

        #region Properties

        public int Ano
        {
            get;set;
        }

        protected string Tipo
        {
            get;set;
        }
        #endregion

        #region Overrides

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

        #region OtherMethods

        /// <summary>
        /// Metodo para reescrever na classe filho
        /// </summary>
        /// <returns></returns>
        public virtual string GetVeiculoDetails()
        {
            return "Vei: " + tipo;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Veiculo()
        {
        }
        #endregion

        #endregion
    }
}
