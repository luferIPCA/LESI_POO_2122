/**
 * Manipular Exceções
 * lufer
 */
using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int[] valores = new int[10];

            x = 10;
            bool ok = false;


            try
            {
                double propina = 23.5;
                if (propina < 30)
                {
                    throw new AlunoNaoPagaPropinasException("Tem de pagar...");
                }
            }
            catch (AlunoNaoPagaPropinasException p)
            {
                Console.WriteLine(p.Message + " Então pague...");
            }

            Console.ReadKey();

            //Analisar Tipo de excepções
            do
            {
                try
                {
                    Console.WriteLine("Valor: ");
                    int xx = int.Parse(Console.ReadLine());

                    xx = valores[x];
                    ok = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Erro..." + e.Message);

                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Erro..." + e.Message);
                    ok = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro..." + e.Message);
                }
            }
            while (ok != true);


            try
            {
                bool aux = TrataDados();
                //int k = int.Parse("ola mundo");
                //DateTime d = DateTime.Parse("120-12-2012");
                //throw new DataInvalidaException("TESTE", new Exception("TESTE"));
                throw new AlunoNaoPagaPropinasException("TESTE", new Exception("TESTE"));
            }
            catch (MyException m)
            {
                Console.WriteLine("MESG: " + m.Message);
            }
            catch (FormatException e)
            {
                //Console.WriteLine("Main Formato: " + e.Message + " ...Contacte o seu admin");
            }
            catch(AlunoNaoPagaPropinasException e)
            {
                Console.WriteLine("Message Final: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Main Geral : " + e.Message + " ...Contacte o seu admin");
            }
            Console.ReadKey();

        }

        static bool TrataDados()
        {
            int x;
            try
            {
                Console.Write("Valor: ");
                x = int.Parse(Console.ReadLine());      //pode gerar erro
                Console.WriteLine("Valor Lido: " + x.ToString());


                DateTime d;
                Console.Write("Data: ");
                d = DateTime.Parse(Console.ReadLine()); //pode gerar
                Console.WriteLine("Data Lida: " + d.ToString());

                int[] valores = new int[10];

                Console.Write("Índice (<10): ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine($"Valor da posição {x}: {++valores[x]}");  //gera exception!!!
                Console.ReadKey();
            }
            catch (IndexOutOfRangeException i)
            {
                Console.WriteLine($"Erro Índice: {i.Message}");
                //return false;
            }
            catch (FormatException f)
            {
                //Suportar de imediato o problema
                //enviar email ao admin

                //Console.WriteLine($"Erro Formato Dados: {f.Message}");
                //return false;

                //reportar o problema
                //throw new FormatException($"Erro Formato Dados: {f.Message}");
                //throw new MyException("Aconteceu algo com os dados...");
                throw new MyException(f);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro Geral: {e.Message}");
                //return false;
            }
            finally
            {
                Console.WriteLine("Finally...");
               
            }
            Console.ReadKey();
            return true;
        }
    }
}
