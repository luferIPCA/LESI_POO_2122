/*
*	<copyright file="Aula_7___Consolidacao.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/8/2021 9:47:29 PM</date>
*	<description></description>
**/
using System;

namespace Aula_7___Consolidacao
{
    public enum Tipo { CASA=10,PREDIO=100,BAIRRO=200}

    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/8/2021 9:47:29 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Imobiliario : ImobiliarioAbs
    {
        #region Attributes
        Tipo t;
        DateTime anoConstrucao;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Imobiliario()
        {
            anoConstrucao = DateTime.Today;
            t = Tipo.CASA;
        }

        public Imobiliario(Tipo t, DateTime d)
        {
            anoConstrucao = d;
            this.t = t;
        }
        public Imobiliario(DateTime d, Tipo t)
        {
            anoConstrucao = d;
            this.t = t;
        }



        #endregion

        #region Properties
        public Tipo T
        {
            get;set;
        }

        public DateTime AnoContsrucao
        {
            get;set;
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public override int GetCodImobiliario()
        {
            throw new NotImplementedException();
        }

        public virtual DateTime GetAnoConst()
        {
            return (anoConstrucao.AddDays(300));
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Imobiliario()
        {
        }
        #endregion

        #endregion
    }
}
