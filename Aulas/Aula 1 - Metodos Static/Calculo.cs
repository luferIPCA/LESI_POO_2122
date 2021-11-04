/*
*	<copyright file="Aula1.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>9/29/2021 9:14:52 PM</date>
*	<description>
*	Métodos Static
*	</description>
**/
using System;

namespace Aula1
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 9/29/2021 9:14:52 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Calculo
    {
        #region Attributes
        
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Calculo()
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
        /// <returns>A soma dos doois valores</returns>
        public static int Soma(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valores"></param>
        /// <returns></returns>
        public static int Maior(int[] valores)
        {
            int maior = valores[0];
            for(int i=1;i<valores.Length; i++)
            {
                if (maior >= valores[i]) continue;
                maior = valores[i];
            }
            return maior;
        }


        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Calculo()
        {
        }
        #endregion

        #endregion
    }
}
