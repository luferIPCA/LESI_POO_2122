/*
*	<copyright file="Aula_7___Consolidacao.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/8/2021 9:57:22 PM</date>
*	<description></description>
**/
using System;

namespace Aula_7___Consolidacao
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/8/2021 9:57:22 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Predio : Imobiliario, IPredio
    {
        #region Attributes
        public int codPredio;
        public string morada;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Predio()
        {
        }

        public Predio(DateTime d, Tipo t, string morada)
        {
            base.AnoContsrucao = d;
            base.T = t;
            this.morada = morada;
        }

        public Predio(Tipo t, DateTime d, string morada): base(t,d)
        {
            //base.AnoContsrucao = d;
            //base.T = t;
            this.morada = morada;
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public override DateTime GetAnoConst()
        {
            return base.GetAnoConst().AddDays(300);
        }

        public int GetDiasConstrucao()
        {
            return base.GetAnoConst().Year * 365;
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Predio()
        {
        }
        #endregion

        #endregion
    }
}
