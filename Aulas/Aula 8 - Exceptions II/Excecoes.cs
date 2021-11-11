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
    public class EsseClubeNaoExisteHaDuvidasException : ApplicationException
        {
            public EsseClubeNaoExisteHaDuvidasException() : base("Isso é clube?") { }


            public EsseClubeNaoExisteHaDuvidasException(string s) : base(s) { }


            public EsseClubeNaoExisteHaDuvidasException(string s, Exception e)
            {
                throw new EsseClubeNaoExisteHaDuvidasException(e.Message + " - " + s);
            }
        }
}
