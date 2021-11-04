/*
*	<copyright file="Aula4_Classes.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/18/2021 9:48:14 PM</date>
*	<description></description>
**/
using System;

namespace Aula4_Classes
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/18/2021 9:48:14 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Ipca
    {
        #region Attributes
        static Turma[] turmas;       //único - Singleton!!!
        static int totTurmas;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor static.
        /// </summary>
        static Ipca()
        {
            turmas = new Turma[40];
            totTurmas = 0;
        }

        /// <summary>
        /// Construtor de Classe - criar objetos
        /// </summary>
        public Ipca()
        {

        }

        #endregion

        #region Properties
        #endregion

        #region Overrides

        //public override string ToString()
        //{

        //    return base.ToString();
        //}
        #endregion

        #region OtherMethods

        public static bool ExisteTurma(int codTurma, string nomeAluno)
        {
            for(int i=0; i < totTurmas; i++)
            {
                if(turmas[i].numTurma==codTurma)
                {
                    //QUem procura dentro da turma é método da classe Turma
                    return turmas[i].ExisteAluno(nomeAluno);
                }
            }
            return false;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Ipca()
        {
        }
        #endregion

        #endregion
    }
}
