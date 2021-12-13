using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TestePOO_EIM
{
    class Program
    {
        static void Main(string[] args)
        {

            Produtos p = new Produtos();

            p.Save("MaisBarato", new List<Produto>()); ;
        }
    }


    public class Produto {
        public TipoProduto t;

    }

    public enum TipoProduto { A,B}

    /// <summary>
    /// b)
    /// </summary>
    public interface IMercado
    {
        bool InsereProduto(Produto p);
        bool RemoveProduto(DateTime d);
        List<Produto> GetAll(TipoProduto t);
    }


    /// <summary>
    /// 
    /// </summary>
    public class Mercados : IMercado
    {
        Dictionary<TipoProduto, List<Produto>> armazem;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public List<Produto> GetAll(TipoProduto t)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// b i) d i)
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public virtual bool InsereProduto(Produto p)
        {

            TipoProduto t = p.t;

            foreach(TipoProduto ti in armazem.Keys)
            {
                //if (p.t==ti)
                if (ti == TipoProduto.B) { }

                if (ti.Equals(p.t)) { };
            }

            if (!armazem.ContainsKey(t))    
            {
                armazem.Add(t, new List<Produto>());    //gere colisões
            }
            if (!armazem[t].Contains(p))    //evita repetidos
            {
                armazem[t].Add(p);
                return true;
            }
            return false;
        }

        public bool RemoveProduto(DateTime d)
        {
            throw new NotImplementedException();
        }
    }

    public class Produtos : Mercados
    {

        public override bool InsereProduto(Produto p)
        {
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="foraDePrazo"></param>
        /// <returns></returns>
        public bool Save(string fileName, List<Produto> foraDePrazo)
        {
            //foraDePrazo = Devolve todos os que estão fora de prazo
            try
            {
                Stream s = File.Open(fileName, FileMode.Create, FileAccess.ReadWrite);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, foraDePrazo);
                s.Flush();
                s.Close();
                s.Dispose();
            }
            catch (Exception e)
            {
                throw; //algo se passou
            }
            finally
            {

            }
            return true;
        }
    }
 

    #region GrupoII
    class Pacient
    {

    }
    interface IUrgencia
    {
        /// <summary>
        /// Insert a new pacient. Return to total of pacients
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        double NewPacient(Pacient p);
    }
    abstract class UrgenciaAbs : IUrgencia
    {
        const int MAXPACIENTSURGENCY = 100;
        public abstract double AddPacient(Pacient p);
        public abstract int TotPacients { get; }

        public double NewPacient(Pacient p)
        {
            if (TotPacients >= MAXPACIENTSURGENCY)
                throw new NoMorePacientsException();
            return AddPacient(p);
        }
    }

    class Urgencia : UrgenciaAbs
    {

        List<Pacient> urgency;
        int tot;


        public Urgencia()
        {
            urgency = new List<Pacient>();
            tot = 0;
        }
        public override int TotPacients {
            get { return tot; }
            //set => throw new NotImplementedException(); 
        
        }
        public override double AddPacient(Pacient p)
        {
            //Testar existencia
            urgency.Add(p);
            tot++;
            return urgency.Count;
        }
    }


    public class NoMorePacientsException : ApplicationException
    {

    }
    #endregion
}
