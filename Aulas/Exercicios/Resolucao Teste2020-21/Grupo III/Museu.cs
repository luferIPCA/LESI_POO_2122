/*
*	<copyright file="Grupo_III.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/22/2021 10:19:27 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;

namespace Grupo_III
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 11/22/2021 10:19:27 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Museu
    {
        #region Attributes
        List<Visitante> visitantes;
        string nome;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Museu()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public bool RegistaVisita(Visitante v, DateTime d)
        {
            //testar regras
            if (PodeVisitar(v, d))
            {
                visitantes.Add(v);
                return true;
            }
            //else
            //    throw new NaoPagouAsCotasException();
            return false;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public bool PodeVisitar(Visitante v, DateTime dia)
        {
            foreach(Visitante vis in visitantes)
            {
                if (vis.codVisitante == v.codVisitante && vis.data.Year == dia.Year)
                    return false;
            }

            return true;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Museu()
        {
        }
        #endregion

        #endregion
    }

    public class Visitante
    {
        public DateTime data;
        public int codVisitante;
    }

}
