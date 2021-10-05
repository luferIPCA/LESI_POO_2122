/*
*	<copyright file="Aula2.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/4/2021 9:24:21 PM</date>
*	<description>
*	Parametros
*	Arrays
*	</description>
**/

using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region parametros

            int x, b = 10, c = 12;
            x = Parametros.Soma(b, c);          //não altera os valores de b e c

            x = Parametros.SomaII(ref b, ref c);//vai alterar os valores de b e c

            int r;

            x = Parametros.SomaProduto(b, c, out r);

            #endregion

            #region Arrays

            //simples

            const int N = 10;
            //int[] v;
            //v = new int[N];
            //ou
            int[] v = new int[N];
            int[] v1 = new int[] { 2, 3, 4, 5 };
            int[] v2 = { 11, 2, -3, 4, -5 };

            for(int i=0; i<v2.Length; i++)
            {
                Console.WriteLine(v2[i].ToString());
            }

            foreach(int valor in v2)
            {
                Console.WriteLine(valor.ToString());
            }

            Console.WriteLine("\nOriginal:");
            Arrays.MostraArray(v2);
            Console.WriteLine("\nOrdenado:");
            int[] aux = Arrays.OrdenaPreservaOriginal(v2);
            Arrays.MostraArray(aux);

            //bidimensional = Matriz

            int[,] mat = new int[,] { { 1, 2, 3 }, { 8, 7, 0 } };
            Console.WriteLine("\nMatriz:");
            Arrays.MostraMatriz(mat);

            //Jagged Array

            int[][] salas = new int[3][];

            salas[0] = new int[10];
            salas[1] = new int[2];
            salas[2] = new int[3];
            Console.WriteLine("\nJaggedn:");
            Arrays.MostraJagged(salas);

            Console.ReadKey();
            #endregion
        }
    }
}
