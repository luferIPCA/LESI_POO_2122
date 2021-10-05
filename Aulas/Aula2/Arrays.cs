/*
*	<copyright file="Aula2.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/4/2021 9:53:38 PM</date>
*	<description>
*	Arrays simples, multidimensionais, jagged
*	Foreach
*	</description>
**/
using System;

namespace Aula2
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/4/2021 9:53:38 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Arrays
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Arrays()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Encontrar o 1º valor par
        /// </summary>
        /// <param name="v"></param>
        /// <param name="par">Valor par encontrado</param>
        /// <returns>True or False</returns>
        public static bool ValorParArray(int[] v, out int par)
        {
            foreach (int valor in v)
            {
                if (valor % 2 == 0)
                {
                    par = valor;
                    return true;
                }
            }
            par = 1;
            return false;

            
        }

        /// <summary>
        /// Apresenta conteúdo de um array
        /// </summary>
        /// <param name="v"></param>
        public static void MostraArray(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i].ToString());
            }
        }

        //Exercicio
        //Origem: Luis Gonzaga de      Martins Ferreira
        //Final: Ferreira, Luis, G. M.

        /// <summary>
        /// Apresenta uma matriz N*M
        /// </summary>
        /// <param name="mat"></param>
        public static void MostraMatriz(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j].ToString());
                    if (j < (mat.GetLength(1) - 1))
                        Console.Write("-");
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Aparesenta Jagged Array
        /// </summary>
        /// <param name="mat"></param>
        public static void MostraJagged(int[][] mat)
        {
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    Console.Write(mat[i][j].ToString());
                    if (j < (mat[i].Length - 1))
                        Console.Write("-"); 
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Ordena um array, alterando o original
        /// </summary>
        /// <param name="mat"></param>
        public static void Ordena(int[] mat)
        {
            for (int i = 0; i < mat.Length-1; i++)
            {
                for (int j = i+1; j < mat.Length; j++)
                {
                    if (mat[i] > mat[j]) //troca
                    {
                        int t = mat[i];
                        mat[i] = mat[j];
                        mat[j] = t;
                    }
                }
            }
        }

        /// <summary>
        /// Ordena um array perservando o original
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public static int[] OrdenaPreservaOriginal(int[] mat)
        {
            int[] aux = new int[mat.Length];
            Array.Copy(mat, aux, mat.Length);
            Arrays.Ordena(aux);
            return aux;
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Arrays()
        {
        }
        #endregion

        #endregion
    }
}
