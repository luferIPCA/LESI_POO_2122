/*
 * LP2
 * Excecoes
 * Lidar com novas exceções
 * 2017-2018
 * lufer
 * */
using System;

namespace Exceptions_II
{
    class Program
    {
        //estado
        static string[] clubes = new string[2];

        static void Main(string[] args)
        {
                #region Exer1
                /*
                //h1
                int[] aux = new int[2];
                int i;

                try
                {
                    i = int.Parse(Console.ReadLine());
                    aux[i] = 3;
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("ERRO= " + e.Message);
                }

                catch (FormatException e)
                {
                    Console.WriteLine("ERRO= " + e.Message);
                }

                catch (Exception e)
                {
                    Console.WriteLine("ERRO= " + e.Message);
                }
                */

                #endregion

                #region Exer2

                //clubes[0] = "Porto";
                string c;
                try
                {
                    Console.Write("Nome do Clube: ");
                    c = Console.ReadLine();
                    InsereClube(c, 2);
                }
                catch (EsseClubeNaoExisteHaDuvidasException e)
                {
                    Console.WriteLine("Mensagem = " + e.Message);
                    Console.WriteLine("HelpLink = " + e.HelpLink);
                    Console.WriteLine("TargetSite = " + e.TargetSite);
                    Console.WriteLine("StackTrace = " + e.StackTrace);
                    Console.WriteLine("Source = " + e.Source);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("ERRO= " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERRO= " + e.Message);
                }


                Console.ReadKey();
                #endregion
            }


        /// <summary>
        /// Insere clube no array...
        /// </summary>
        /// <param name="s"></param>
        /// <param name="i"></param>
        public static void InsereClube(string s, int i)
        {
            if (string.Compare(s, "Porto") == 0)
            {
                //throw new Exception("Isso não é clube...!");
                //throw new EsseClubeNaoExisteHaDuvidasException();
                throw new EsseClubeNaoExisteHaDuvidasException("Ainda se fosse Benfica...", new Exception("Azar"));
            }
            try
            {
                clubes[i] = s;
            }
            catch (Exception e)
            {
                throw new EsseClubeNaoExisteHaDuvidasException("Ainda se fosse Benfica...", e);
            }
        }
    }
}
