/*
*	<copyright file="ResolucaoTeste2020_21.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/22/2021 9:46:21 PM</date>
*	<description></description>
**/
using System;

namespace ResolucaoTeste2020_21
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/22/2021 9:46:21 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public abstract class QuasePessoa
    {
        #region Attributes
        protected string morada;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public QuasePessoa()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Devolve a morada da pessoa
        /// </summary>
        /// <returns></returns>
        public abstract string Morada();
        /// <summary>
        /// Devolve o número de dias que decorreram desde o nascimento
        /// </summary>
        /// <param name="dn"></param>
        protected long GetDiasVida(DateTime dn)
        {
            return (DateTime.Now - dn).Days;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~QuasePessoa()
        {
        }
        #endregion

        #endregion
    }
}
