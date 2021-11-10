/*
*	<copyright file="Aula_7___Consolidacao.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/8/2021 10:10:59 PM</date>
*	<description></description>
**/
using System;

namespace Aula_7___Consolidacao
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/8/2021 10:10:59 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Bairro : Imobiliario, IPredio
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Bairro()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides

        public override DateTime GetAnoConst()
        {
            return base.GetAnoConst();
        }

        public int GetDiasConstrucao()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Bairro()
        {
        }
        #endregion

        #endregion
    }
}
