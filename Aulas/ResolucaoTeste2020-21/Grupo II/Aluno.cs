/*
*	<copyright file="GrupoII.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/22/2021 9:51:13 PM</date>
*	<description></description>
**/
using System;

namespace GrupoII
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/22/2021 9:51:13 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Aluno
    {
        #region Attributes
        public int numAluno;        //atenção ao public
        public string uc;
        public string curso;
        public int epoca;
        public int nota;


        DateTime data;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Aluno()
        {
        }

        #endregion

        #region Properties
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
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
        ~Aluno()
        {
        }
        #endregion

        #endregion
    }
}
