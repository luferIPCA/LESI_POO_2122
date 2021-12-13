/*
*	<copyright file="Exercicio_11_10_2021.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/11/2021 2:58:15 PM</date>
*	<description></description>
**/
using System;

namespace Exercicio_11_10_2021
{

    #region Doentes
    public enum Estado { ALTA, UCI, INTERNADO };

    public struct Doente
    {
        public string nome;
        //estado
        public Estado estado;
        public int idade;
        public DateTime dataInternamento;
    }
    #endregion

    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/11/2021 2:58:15 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Exercicio
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Exercicio()
        {
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
        ~Exercicio()
        {
        }
        #endregion

        #endregion

        #region ArraySimples
        public static bool Existe(int[] v, int valor) { 
            //h1
            //int size = v.Length;
            //for (int i = 0; i < size; i++)
            //{
            //    if (v[i] == valor) return true;
            //}
            //return false;
            //h2
            foreach(int aux in v)
            {
                if (aux == valor) return true;
            }
            return false;

        }

        /// <summary>
        /// Verifica se determinado doente existe no hospital
        /// </summary>
        /// <param name="hospital"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool ExisteDoente(Doente[] hospital, string n)
        {
            foreach(Doente d in hospital)
            {
                if (d.nome.CompareTo(n) == 0) return true;
                //if (String.Compare(d.nome, n) == 0) return true;
                //if (d.nome == n) return true;
            }
            return false;
        }

        /// <summary>
        /// Remove elemento de um array
        /// O número de elementos do array define as posições ocupadas
        /// </summary>
        /// <param name="v">array</param>
        /// <param name="valor">valor a remover</param>
        /// <returns>Número de elementos do array</returns>
        public static int RemoveElemento(int[] v, int valor)
        {
            int pos = -1;       //posição com o elemento a remover
            //encontrar o elemento a remover
            for(int i=0; i<v.Length;i++)
            {
                if (v[i]==valor)
                {
                    pos = i; break;
                }
            }
            if (pos == -1) return -1;//se não encontrou o valor, termina

            //remover o elemento
            int newSize = v.Length - 1;
            for (int k = pos; k < newSize; k++)
            {
                v[k] = v[k + 1];
            }
            return newSize;
        }

        /// <summary>
        /// Remove elemento de um array
        /// O número de elementos do array define as posições ocupadas
        /// Elementos removidos passam a "null" no array
        /// </summary>
        /// <param name="v">array de valores nullable </param>
        /// <param name="valor">valor a remover</param>
        /// <returns>Número de elementos do array</returns>
        public static int RemoveElementoNull(int?[] v, int valor)
        {
            int pos = -1;       //posição com o elemento a remover

            //if (v[0]==null)
            //encontrar o elemento a remover
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == valor)
                {
                    pos = i; break;
                }
            }
            if (pos == -1) return -1;//se não encontrou o valor
            //remover o elemento
            int newSize = v.Length - 1;
            for (int k = pos; k < newSize; k++)
            {
                v[k] = v[k + 1];
            }
            v[newSize] = null;      //marca valor removido
            return newSize;
        }

        #endregion

        #region ArrayMultidimensional

        /// <summary>
        /// Verifica se determinado valor existe num array bidimensional
        /// </summary>
        /// <param name="valores"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool ExisteMulti(int[,] valores, int v)
        {
            //Percorrer todas as linhas
            for(int lin=0; lin < valores.GetLength(0); lin++)
            {
                //Para cada linha, percorro todas as colunas
                for(int col=0; col<valores.GetLength(1);col++)
                {
                    if (valores[lin, col] == v) return true;
                }
            }
            return false;
        }



        #endregion

        #region ArrayJagged

        /// <summary>
        /// Verifica se determinado valore existe num jagged array
        /// </summary>
        /// <param name="valores"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool ExisteJagged(int[][] valores, int v)
        {
            //percorre todas as linhas do array
            for (int l = 0; l < valores.Length; l++)
            {
                //percorre todas as colunas de cada linha
                for (int c = 0; c < valores[l].Length; c++)
                {
                    if (valores[l][c] == v) return true;
                }
            }
            return false;
        }

        #endregion

        #region Doentes
        //Exercicio de Aula :12-10-2021
        //Encontrar o doente que se encontra hospitalizado
        //à mais tempo
        //arrays, structs, datetime

        public static Doente InternadoHaMaisTempo(Doente[] hospital)
        {
            Doente aux = hospital[0];
            int dias = 0;
            foreach (Doente d in hospital)
            {
                int xx = (DateTime.Today.Subtract(d.dataInternamento)).Days;

                if (xx > dias)
                {
                    aux = d;
                    dias = xx;
                }
            }
            return aux;
        }
        #endregion

    }




}
