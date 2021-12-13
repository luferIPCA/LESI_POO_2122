/*
*	<copyright file="ResolucaoTeste2020_21.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/22/2021 9:45:26 PM</date>
*	<description></description>
**/
using System;

namespace ResolucaoTeste2020_21
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/22/2021 9:45:26 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    /// <summary>
    /// 
    /// </summary>
    public class Pessoa : QuasePessoa, IDados
    {
        double nc;
        DateTime dn;

        /// <summary>
        /// 
        /// </summary>
        public DateTime DN
        {
            get => dn;
            set => dn = value;
        }

        /// <summary>
        /// Pro
        /// </summary>
        public double NC
        {
            get; set;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public long DiaDaSemana()
        {
            return (long)dn.DayOfWeek;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public long GetDiasVida()
        {
            return dn.Year * 365;   //Não consegui calcular o número de dias...
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Morada()
        {
            return morada;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Pessoa p1, Pessoa p2)
        {
            double nc1 = p1.NC;
            double nc2 = p2.NC;

            int mesP1 = p1.DN.Month;
            int mesP2 = p2.DN.Month;

            return ((nc1 == nc2) && (mesP1 == mesP2));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Pessoa p1, Pessoa p2)
        {
            return (!(p1 == p2));
        }
    }
}
