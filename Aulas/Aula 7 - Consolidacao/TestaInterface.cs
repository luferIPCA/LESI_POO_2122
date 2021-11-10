/*
*	<copyright file="Aula_7___Consolidacao.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/8/2021 10:17:47 PM</date>
*	<description></description>
**/
using System;

namespace Aula_7___Consolidacao
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/8/2021 10:17:47 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class TestaInterface
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public TestaInterface()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public static int GetAno(IPredio p)
        {
            if (p is Predio)
                    return p.GetDiasConstrucao();

            if (p is Bairro)
                return p.GetDiasConstrucao()-200;

            return 0;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~TestaInterface()
        {
        }
        #endregion

        #endregion
    }
}
