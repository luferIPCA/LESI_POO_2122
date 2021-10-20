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
        public int idade;           //atenção: retirar public
        string nome;

        static int totObjetos;      //atributo de class: conta o número de objetos do tipo Pessoa
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
            totObjetos++;           //incremento o número de pessoas
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

        public override string ToString()
        {
            return $"Pessoa: {nome} - Idade: {idade}";
        }

        /// <summary>
        /// Compara dois objetos
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {         
            Pessoa t = obj as Pessoa;
            //Pessoa t = (Pessoa)obj;
            if (t.nome == this.nome && t.idade == this.idade)
                return true;
            return false;

        }

        #endregion

        #region OtherMethods

        #region Operators
        public static bool operator ==(Pessoa p1, Pessoa p2)
        {
            return (p1.Equals(p2));
        }

        public static bool operator !=(Pessoa p1, Pessoa p2)
        {
            return (!(p1 == p2));
        }

        #endregion

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
