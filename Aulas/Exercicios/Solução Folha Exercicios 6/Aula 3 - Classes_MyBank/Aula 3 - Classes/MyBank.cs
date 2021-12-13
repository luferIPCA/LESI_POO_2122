// -------------------------------------------------
// <copyright file="MyBank.cs" company="IPCA">
// </copyright>
// <summary>
//	LP2 - 2018-2019
// </summary>
//-------------------------------------------------

using System;

namespace Classes
{
    enum Tipo { DEB,CRED};

    /// <summary>
    /// Descreve uma Conta Bancária
    /// </summary>
    public class BankAccount
    {
        #region MEMBROS

        #region ATTR

        const int MAX = 1000;
        private string number;
        private string owner;
        private decimal balance;
        //Número inicial de contas: atributo de classe!
        private static int accountNumberSeed = 1234567890;
        //Gerir Transações
        //h1: Incluir conjunto de transações
        private Transaction[] allTransactions = new Transaction[MAX];
        ////Número de transações
        private int totTrans=0;
        //ou
        //h2: incluir instância de classe Transações
        Transacoes t;

        #endregion

        #region PROPERTIES
        public string Number
        {
            get { return number; }
        }
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public decimal Balance
        {
            //h1
            //get { return balance; }
            //h2
            
            get
            {
                decimal balance = 0;
                for (int i=0; i<totTrans;i++)
                {
                    balance += allTransactions[i].Amount;
                }
                //h2
                //Invocar um método que a classe Transactions possua para calcular o balance

                return balance;
            }
            
        }

        #endregion

        #region METODOS

        #region CONST
        public BankAccount(string name, decimal initialBalance)
        {
            this.owner = name;
            this.balance = initialBalance;
            //this.number = ?????
            //this.number = accountNumberSeed.ToString();
            //accountNumberSeed++;
            //MakeDeposit(initialBalance, DateTime.Now, "Saldo inicial1\");

            //Criar instância das Transações
            t = new Transacoes(MAX);
            
        }
        #endregion
        /// <summary>
        /// Depósito
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="date"></param>
        /// <param name="note"></param>
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                //Erro
                //throw new ArgumentOutOfRangeException(nameof(amount), "Montante a depositar deve ser positivo...");
            }
            //cria transação
            var deposit = new Transaction(amount, date, note);
            //regista transação
            if (totTrans < MAX)
            {
                allTransactions[totTrans++] = deposit;
            }

            //Falta registar transação na instância de "Transações"
        }

        /// <summary>
        /// Levantamento
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="date"></param>
        /// <param name="note"></param>
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                //Erro
                //throw new ArgumentOutOfRangeException(nameof(amount), "Montante a levantar deve ser positivo...");
            }
            if (balance - amount < 0)
            {
                //Erro
                //throw new InvalidOperationException("Não tem dinheiro suficiente...");
            }
            var withdrawal = new Transaction(-amount, date, note);
            //regista transação
            if (totTrans < MAX)
            {
                allTransactions[totTrans++] = withdrawal;
            }

            //Falta registar transação na instância de "Transações"
        }

        /// <summary>
        /// Gera um extrato
        /// </summary>
        /// <param name="nc"></param>
        /// <returns></returns>
        public string Extrato(string nc)
        {
            string aux = t.Extrato(nc);
            //regras
            return aux; ;
        }
        
        #endregion

        #endregion
    }

    /// <summary>
    /// Classe que descreve uma transação
    /// </summary>
    public class Transaction
    {
        #region ATTR

        private decimal amount;
        private DateTime date;
        private string notes;

        #endregion

        #region METODOS
        public decimal Amount {
            get { return amount; } 
            set{ amount = value; }
        }
        //C#>=6.0
        //public decimal Amount { get => amount; set => amount = value; }
        public DateTime Date { get; }
        public string Notes { get; }
        
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="date"></param>
        /// <param name="note"></param>
        public Transaction(decimal amount, DateTime date, string note)
        {
            this.amount = amount;
            this.date = date;
            this.notes = note;
        }

        #endregion
    }


    /// <summary>
    /// Classe que descreve um conjunto de transações
    /// </summary>
    public class Transacoes
    {
        const int MAX = 1000;
        Transaction[] allTransactions;// = new Transaction[MAX];
        //Número de transações
        int totTrans;// = 0;

        public Transacoes(int n)
        {
            allTransactions = new Transaction[n];
            totTrans = 0;
        }


        //public bool InsereTransacao(DateTime d, float v, Tipo t)
        //{
        //    allTransactions[totTrans++] = new Transaction((decimal)v, d, t.ToString());
        //    return true;
        //}

        public bool InsereTransacao(Transaction t)
        {
            allTransactions[totTrans++] = t;
            return true;
        }

        public string Extrato(string numConta)
        {
            string s = "";

            for(int i=0; i<totTrans; i++)
            {
                s += allTransactions[i].Date.ToString() + "-" + allTransactions[i].Amount;
            }

            return s;
        }
    }

   
}

