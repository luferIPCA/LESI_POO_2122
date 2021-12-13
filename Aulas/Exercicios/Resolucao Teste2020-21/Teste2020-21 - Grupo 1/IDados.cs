/*
*	<copyright file="ResolucaoTeste2020_21.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/22/2021 9:31:12 PM</date>
*	<description></description>
**/
using System;

namespace ResolucaoTeste2020_21
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/22/2021 9:31:12 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public interface IDados
    {
        /// <summary>
        /// Devolve o dia da semana em que nasceu
        /// </summary>
        /// <returns></returns>
        long DiaDaSemana();
        /// <summary>
        /// Devolve o NC da pessoa
        /// </summary>
        double NC { get; }
        /// <summary>
        /// Devolve o número de dias que decorreram desde o nascimento
        /// </summary>
        /// <param name="dn"></param>
        /// <returns></returns>
        long GetDiasVida();
    }

      

}
