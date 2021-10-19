/*
*	<copyright file="Aula4_Classes.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/18/2021 9:27:06 PM</date>
*	<description></description>
**/
using System;

namespace Aula4_Classes
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/18/2021 9:27:06 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoa
    {
        #region Attributes
        public int idade;
        string nome;

        static int totObjetos;      //atributo de class
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Pessoa()
        {
            idade = 0;
            nome = "";
            totObjetos++;
        }

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            totObjetos++;
        }

        #endregion

        #region Properties
        public string Nome
        {
            get { return nome; }
            set { if (value.Length>0) nome = value; }        
        }

        public static int TotObjetos
        {
            get { return totObjetos; }
        }

        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Pessoa()
        {
        }
        #endregion

        #endregion
    }
}
