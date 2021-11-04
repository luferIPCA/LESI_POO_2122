/*
*	<copyright file="Aula2.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/4/2021 9:24:21 PM</date>
*	<description>
*	Parametros: ref, out
*	</description>
**/
using System;

namespace Aula2
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/4/2021 9:24:21 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Parametros
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Parametros()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods


        public static int Soma(int x, int y)
        {
            x++;y++;
            return x + y;
        }


        public static int SomaII(ref int x, ref int y)
        {
            x++; y++;
            return x + y;
        }

        public static int SomaProduto(int x, int y, out int r)
        {
            r = x * y;
            return x + y;
        }

        

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Parametros()
        {
        }
        #endregion

        #endregion
    }
}
