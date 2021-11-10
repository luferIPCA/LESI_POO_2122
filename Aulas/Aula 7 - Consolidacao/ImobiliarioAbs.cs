/*
*	<copyright file="Aula_7___Consolidacao.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/8/2021 9:42:50 PM</date>
*	<description></description>
**/
using System;

namespace Aula_7___Consolidacao
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/8/2021 9:42:50 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public abstract class ImobiliarioAbs
    {
        #region Attributes
        int codImobiliario;
        #endregion

        #region Methods

        #region Constructors

        #endregion

        #region Properties

        public int CodImobiliario
        {
            set { codImobiliario = value; }
        }
        #endregion


        #region Overrides
        #endregion

        #region OtherMethods

        public abstract int GetCodImobiliario();
        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}
