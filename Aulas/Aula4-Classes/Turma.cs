/*
*	<copyright file="Aula4_Classes.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/18/2021 9:38:23 PM</date>
*	<description>
*	Set(Pessoas)
*	</description>
**/
using System;

namespace Aula4_Classes
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/18/2021 9:38:23 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Turma
    {
        #region Attributes
        const int MAX = 10;
        Pessoa[] alunos;
        int totAlunos;
        public int numTurma;        //ATENÇÂO: private

        //static Turma[] ipca;
        //static int totTurmas;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Turma()
        {
            alunos = new Pessoa[MAX];
            totAlunos = 0;
        }

        public Turma(int tamanhoTurma)
        {
            if (tamanhoTurma<0 || tamanhoTurma > MAX)
                tamanhoTurma = MAX;
            alunos = new Pessoa[tamanhoTurma];
            totAlunos = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        //static Turma()
        //{
        //    ipca = new Turma[MAX];
        //    totTurmas = 0;
        //}

        #endregion

        #region Properties

        /// <summary>
        /// EVITAR!!!
        /// </summary>
        //public Pessoa[] Alunos
        //{
        //    get { return alunos; }      //Clone
        //}

        public int TotAlunos
        {
            get { return totAlunos; }
        }
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public bool ExisteAluno(string nome)
        {
            for(int i=0; i < totAlunos; i++)
            {
                if (alunos[i].Nome == nome) 
                    return true;
            }
            return false;
        }

        
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Turma()
        {
        }
        #endregion

        #endregion
    }
}
