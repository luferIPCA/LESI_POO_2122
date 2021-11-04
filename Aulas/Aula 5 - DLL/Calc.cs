/*
*	<copyright file="TesteDLL.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/27/2021 9:56:52 PM</date>
*	<description></description>
**/
using System;

namespace TesteDLL
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/27/2021 9:56:52 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Calc
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Calc()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Calcula a soma de dois valores inteiros
        /// </summary>
        /// <param name="x">Valor 1</param>
        /// <param name="y">Valor 2</param>
        /// <returns>Soma deles</returns>
        public static int Add(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Calcula a diferença entre dois valores inteiros
        /// </summary>
        /// <param name="x">Valor 1</param>
        /// <param name="y">Valor 2</param>
        /// <returns></returns>
        public static int Sub(int x, int y)
        {
            return x - y;
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Calc()
        {
        }
        #endregion

        #endregion
    }
}
