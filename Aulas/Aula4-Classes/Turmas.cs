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
    public class Turmas
    {
        #region Attributes
        static Turma[] ipca;       //único - Singleton!!!
        static int totTurmas;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor static.
        /// </summary>
        static Turmas()
        {
            ipca = new Turma[40];
            totTurmas = 0;
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public static bool ExisteTurma(int codTurma, string nomeAluno)
        {
            for(int i=0; i < totTurmas; i++)
            {
                if(ipca[i].numTurma==codTurma)
                {
                    //QUem procura dentro da turma é método da classe Turma
                    return ipca[i].ExisteAluno(nomeAluno);
                }
            }
            return false;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Turmas()
        {
        }
        #endregion

        #endregion
    }
}
