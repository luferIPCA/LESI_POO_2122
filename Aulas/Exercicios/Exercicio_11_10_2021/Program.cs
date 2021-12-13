/*
*	<copyright file="Exercicio_11_10_2021.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/11/2021 2:58:15 PM</date>
*	<description>
*	    Array de Structs
*	</description>
**/

namespace Exercicio_11_10_2021
{
    class Program
    {
        //TPC
        //Ordenar array bidimensional!!!
        //Remover elemento de array Simples
        static void Main(string[] args)
        {
            Doente[] doentes = new Doente[10];
            Doente[] doentes2 = new Doente[] { new Doente() { idade = 12, estado = Estado.ALTA, nome = "" } };
            Doente d1 = new Doente(); ;
            d1.nome = "ola";
            d1.idade = 12;
            d1.estado = Estado.INTERNADO;

            doentes[0] = d1;

            doentes[1].nome = "Ole";
            doentes[1].estado = Estado.ALTA;
            doentes[1].idade = 97;

            int[] valores1 = { 2, 3, 4, 1, 4 };

            int aux = Exercicio.RemoveElemento(valores1, 3);
            
            int?[] valores = { 2, 3, 4, 1, 4 };

            aux = Exercicio.RemoveElementoNull(valores, 3);

        }
    }
}
