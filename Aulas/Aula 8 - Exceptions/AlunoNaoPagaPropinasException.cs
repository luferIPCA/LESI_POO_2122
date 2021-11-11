/*
*	<copyright file="Hoje___Exceptions.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/10/2021 9:56:43 PM</date>
*	<description></description>
**/
using System;

namespace Exceptions
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/10/2021 9:56:43 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class AlunoNaoPagaPropinasException : ApplicationException
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public AlunoNaoPagaPropinasException() : base("Falta pagar proprinas...")
        {
        }

        public AlunoNaoPagaPropinasException(string s) : base(s)
        {
        }

        public AlunoNaoPagaPropinasException(string s, Exception e)
        {
            string res = s + " - " + e.Message;
            throw new AlunoNaoPagaPropinasException(res);
        }

        public AlunoNaoPagaPropinasException(Exception e)
        {
            throw new AlunoNaoPagaPropinasException("ola: " + e.Message);
        }


        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~AlunoNaoPagaPropinasException()
        {
        }
        #endregion

        #endregion
    }

    


    public class DataInvalidaException : ApplicationException
    {
        public DataInvalidaException() : base("Data Inválida")
        {
        }

        public DataInvalidaException(string s) : base(s) { }

        public DataInvalidaException(string s, Exception e)
        {
            //throw new Exception(e.Message + " - " + s);
            throw new DataInvalidaException(e.Message + " - " + s);
        }

    }
}
