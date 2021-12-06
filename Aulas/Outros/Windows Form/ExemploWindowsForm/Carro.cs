/*
*	<copyright file="Carro.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>6/24/2020 5:27:28 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExemploWindowsForm
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 6/24/2020 5:27:28 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Carro
    {
        #region Attributes
        public int ano;
        public string matricula;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Carro(int a, string m)
        {
            ano = a;
            matricula = m;
        }

        #endregion

        #region Properties
        #endregion

        #region Functions
        #endregion

        #region Overrides
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Carro()
        {
        }
        #endregion

        #endregion
    }


    public class Carros
    {
        static List<Carro> parque;


        static Carros()
        {
            parque = new List<Carro>();
        }

        public static bool AddCar(Carro c)
        {
            parque.Add(c);
            return true;
        }

        public static void ShowPark()
        {
            foreach(Carro c in parque)
            {
                MessageBox.Show(c.matricula);
            }
        }

    }
}
