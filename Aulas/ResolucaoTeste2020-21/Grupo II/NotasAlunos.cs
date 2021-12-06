/*
*	<copyright file="GrupoII.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/22/2021 9:55:59 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;

namespace GrupoII
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/22/2021 9:55:59 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class NotasAlunos
    {
        #region Attributes
        List<Aluno> notas;

        protected Dictionary<char, Aluno> aprovados;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public NotasAlunos()
        {
            aprovados = new Dictionary<char, Aluno>();
            notas = new List<Aluno>();
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// método que devolva todos os alunos que tenham tido aprovação a uma determinada unidade curricular, num determinado curso e numa determinada época
        /// </summary>
        /// <param name="uc"></param>
        /// <param name="epoca"></param>
        /// <param name="curso"></param>
        /// <returns></returns>
        public List<Aluno> AprovadosI(string uc, int epoca, string curso)
        {
            List<Aluno> aprov = new List<Aluno>();
            foreach(Aluno a in notas)
            {
                if (a.uc == uc && a.epoca == epoca && a.curso == curso && a.nota >= 10)
                    aprov.Add(a);
            }
            return aprov;
        }

        /// <summary>
        /// Grupo II
        /// </summary>
        /// <param name="uc"></param>
        /// <param name="epoca"></param>
        /// <param name="curso"></param>
        /// <returns></returns>
        public List<Aluno> AprovadosII(string uc, int epoca, string curso)
        {
            List<Aluno> aprov = new List<Aluno>();

            List<char> k = new List<char>(aprovados.Keys);
            foreach (char c in k)
            {
                Aluno aux = aprovados[c];
                if(aux.uc ==uc && aux.epoca==epoca && aux.curso==curso && aux.nota>=10)
                   aprov.Add(aux);
            }
            return aprov;
        }

        
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~NotasAlunos()
        {
        }
        #endregion

        #endregion
    }
}
