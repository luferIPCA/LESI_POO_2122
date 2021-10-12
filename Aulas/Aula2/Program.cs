/*
*	<copyright file="Aula2.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/4/2021 9:24:21 PM</date>
*	<description>
*	Parametros
*	Arrays
*	Enums
*	Format Strings - https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-numeric-format-strings
*	</description>
**/

using System;
using System.Linq;  //Métodos sobre Arrays

namespace Aula2
{
    #region Enums
    public enum Notas { Passou = 10, Reprovou = 9 };
    public enum WeekDays
    {
        Monday,     //0
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday      //6
    }
    public enum Colors { RED = 1, GREEN = 2, Blue = 4, Yellow = 8 };

    #endregion

    class Program
    {
        
        
        public int GetEnum(WeekDays w)
        {

            if (w == WeekDays.Friday) return 0;
            return 1;
        }

        static void Main(string[] args)
        {
            #region Parametros

            int x, b = 10, c = 12;
            x = Parametros.Soma(b, c);          //não altera os valores de b e c

            x = Parametros.SomaII(ref b, ref c);//vai alterar os valores de b e c

            int r;

            x = Parametros.SomaProduto(b, c, out r);

            #endregion

            #region Arrays

            #region simples

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
            #endregion

            #region Multidimensional

            //Bidimensional = Matriz

            int[,] mat = new int[,] { { 1, 2, 3 }, { 8, 7, 0 } };
            Console.WriteLine("\nMatriz:");
            Arrays.MostraMatriz(mat);

            //Tridimensional
            int[,,] valores = new int[2, 3, 2] {
                                            {{1,2},{3,-1},{3,3} },
                                            {{1,2},{3,-1},{3,4} }
                                            };

            //Jagged Array

            int[][] salas = new int[3][];

            salas[0] = new int[10];
            salas[1] = new int[2];
            salas[2] = new int[3];
            Console.WriteLine("\nJagged:");
            Arrays.MostraJagged(salas);

            #endregion

            #region Métodos sobre Arrays

            //LINQ: Max, Min, Sum, Average
            Console.WriteLine("Max V2: {0}", v2.Max());
            Console.WriteLine("Sum Salas: {0}", v2.Sum());

            //Array class
            //Sort, Reverse, ForEach, BinarySearch
            Array.Sort(v2);
            Array.Reverse(v2);
            Array.ForEach(v2, n => Console.WriteLine(n));
            int pos=Array.BinarySearch(v2, -11);

           

            #endregion
            #endregion

            #region Enums
            
            Console.WriteLine(WeekDays.Friday); //output: Friday 
            int day = (int)WeekDays.Friday;     //enum to int conversion
            Console.WriteLine(day);             //output: 4 
            var wd = (WeekDays)5;               //int to enum conversion
            Console.WriteLine(wd);              //output: Saturday 

            //Class Enum
            //Enum.GetValues, Enum.GetName, Enum.Format()
            Type wd1 = typeof(WeekDays);
            foreach (string s in Enum.GetNames(wd1))
                Console.WriteLine("{0,-11}= {1}", s, Enum.Format(wd1, Enum.Parse(wd1, s), "d"));

            #endregion

            #region Exercicios

            #endregion

            int[] merged = Arrays.MergeAndSortArrays(v1, v2);
            Arrays.MostraArray(merged);

            #region ArrayStructs
            Carro[] garagem = new Carro[] { new Carro() { ano = DateTime.Parse("12-12-2009"), cor = Colors.GREEN, marca = "", matricula = "" } };
            #endregion

            Console.ReadKey();
        }
    }
}
