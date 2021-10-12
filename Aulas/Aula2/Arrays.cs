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
using System.Collections.Generic;

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
            int[] aux = new int[mat.Length];    //array auxiliar
            Array.Copy(mat, aux, mat.Length);
            Arrays.Ordena(aux);
            return aux;
        }

       

        /// <summary>
        /// Merge two arrays of same size sorted in ascending order
        /// Exercicio de https://www.w3resource.com/csharp-exercises/array/csharp-array-exercise-7.php
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static int[] MergeAndSortArrays(int[] a1, int[] a2)
        {
            //novo array tem que comportar os dois arrais de entrada
            int[] merged = new int[a1.Length + a2.Length];
            int i = 0;      //indice do novo array

            //Copia o 1º array para o novo!
            foreach(int v in a1)
            {
                merged[i] = v;
                i++;
            }
            //copia o 2º array para o novo!
            foreach (int v in a2)
            {
                merged[i] = v;
                i++;
            }

            Ordena(merged); //metodo anterior
            return merged;

        }

        #region Matrizes
        /// <summary>
        /// Verifica se se trata de uma matriz quadrada binária
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public static bool MatrizDePermutacao(int[,] mat)
        {
            int totUm = 0;
            //total de "1" por linhas
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                totUm = 0;
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == 1) totUm++;
                    if (totUm > 1) return false;
                }
            }
            //total de "1" por colunas
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                totUm = 0;
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[j, i] == 1) totUm++;
                    if (totUm > 1) return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Multiplica duas matrizes
        /// </summary>
        /// <param name="matA"></param>
        /// <param name="matB"></param>
        /// <returns></returns>
        public static int[,] MultiplicaMatrizes(int[,] matA, int[,] matB)
        {
            //Verificar se é possível multiplicar
            //matA(x,y) => matB(y,k)
            //matRes(x,k);
            if (matA.GetLength(1) != matB.GetLength(0)) return null;

            //criar matriz resultado
            int[,] matRes = new int[matA.GetLength(0), matB.GetLength(1)];

            for (int linha = 0; linha < matA.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matB.GetLength(1); coluna++)
                {
                    //matR[1,1] = matA[1,1]*matB[1,1]+matA[1,2]*matB[2,1]+matA[1,3]*matB[3,1]...matA[1,k]*matB[k,1]
                    //matR[i,j] = Somatorio(matA[linha,k]*matB[k,coluna]
                    int soma = 0;
                    for (int k = 0; k < matA.GetLength(1); k++) //ou matB.GetLength(0)
                    {
                        soma += matA[linha, k] * matB[k, coluna];
                    }
                    matRes[linha, coluna] = soma;
                }
            }
            return matRes;
        }
        #endregion


        #region ARRAYSSTRUCTS

        /// <summary>
        /// Analisar diversas abordagens!!!
        /// </summary>
        /// <param name="garagem"></param>
        /// <param name="corProcurar"></param>
        /// <returns></returns>
        public static Carro[] ProcuraCarrosGaragem(Carro[] garagem, Colors corProcurar)
        {
            //h1
            //Carro[] aux = new Carro[garagem.Length];

            //h2
            //1º passo: ver quantos carros existem dessa cor
            int tot = 0;
            foreach(Carro c in garagem)
            {
                if (c.cor == corProcurar) tot++;
            }
            //2º passo: criar array para esses carros
            Carro[] aux1 = new Carro[tot];
            int k=0;
            for(int i=0; i<garagem.Length; i++)
            {
                if (garagem[i].cor == corProcurar)
                {
                    aux1[k++] = garagem[i];
                }
            }
            return aux1;

            //h3: Guardar a posição onde se encontram
            int[] lugaresParque = new int[garagem.Length];
            int k1 = 0;
            for(int i=0; i<garagem.Length; i++)
            {
                if (garagem[i].cor == corProcurar)
                {
                    lugaresParque[k1] = i;
                    k1++;
                }   
            }
            Carro[] aux2 = new Carro[k1];
            //preencher array
            //return aux2;
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="garagem"></param>
        /// <param name="corProcurar"></param>
        /// <returns></returns>
        public static List<Carro> ProcuraCarrosGaragemII(Carro[] garagem, Colors corProcurar)
        {
            List<Carro> aux = new List<Carro>();
            foreach (Carro c in garagem)
            {
                if (c.cor == corProcurar) aux.Add(c);
            }
            return aux;
        }


        #region Exercicios

        #region ArraySimples

        /// <summary>
        /// Encontra o maior valor de um array
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static int MaiorArraySimples(int[] v)
        {
            int aux = v[0];
            int size = v.Length;        //dimensão do array

            for (int i=1; i<size; i++)
            {
                if (v[i] > aux) aux = v[i];
            }
            return aux;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static int PosicaoMaiorArraySimples(int[] v)
        {
            int aux = v[0]; //não é necessário
            int pos = 0;

            int size = v.Length;        //dimensão do array

            for (int i = 1; i < size; i++)
            {
                if (v[i] > aux) { aux = v[i]; pos = i; }
            }
            return pos;

        }

        /// <summary>
        /// Encontra o maior e devolve a posição onde está no erray
        /// </summary>
        /// <param name="v"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public  static int PosicaoValorMaiorArraySimples(int[] v, out int pos)
        {
            //h1 - usar métodos anteriores
            //int maior = PosicaoMaiorArraySimples(v);
            //pos = PosicaoMaiorArraySimples(v);
            //return maior;

            //h2 - implementar tudo
            int maior = v[0]; 
            pos = 0;

            int size = v.Length;        //dimensão do array

            for (int i = 1; i < size; i++)
            {
                if (v[i] > maior) { maior = v[i]; pos = i; }
            }
            return maior;
        }

        #endregion


        #region ArrayMultidimensionais

        /// <summary>
        /// Encontra o maior valor de um array bidimensional
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static int MaiorArrayBidimensional(int[,] v)
        {
            int aux = v[0, 0];
            int nLinhas = v.GetLength(0);
            int nColunas = v.GetLength(1);

            for(int i=0; i<nLinhas; i++)
            {
                for(int j=0; j<nColunas; j++)
                {
                    if (aux < v[i, j]) aux = v[i, j];
                }
            }
            return aux;
        }
        #endregion


        #region ArrayJagged

        /// <summary>
        /// Encontra o maior valor num jagged array
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static int MaiorArraysJagged(int[][] v)
        {
            int aux = v[0][0];
            int nLinhas = v.Length;     //número de linhas de um jagged
            int nColunas;

            for (int i = 0; i < nLinhas; i++)
            {
                nColunas = v[i].Length; //número de colunas da linha corrente
                for(int j=0; j<nColunas; j++)
                {
                    if (aux < v[i][j]) aux = v[i][j];
                }
            }
            return aux;
        }

        #endregion


        #endregion

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

//Exercicios sobre Arrays

//Encontrar maior, menor
//Calcula média, quantos,
//Converter simples em matriz
//Multiplicar matrizes
//Matriz inversa
//Exercicio
//Origem: Luis Gonzaga de      Martins Ferreira
//Final: Ferreira, Luis, G. M.

