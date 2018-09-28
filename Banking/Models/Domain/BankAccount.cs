using System;

namespace Banking.Models.Domain
{
    public class BankAccount
    {
        //private string _accountNumber;
        #region Fields
        private decimal _balance;

        #endregion

        #region Constructors
        public BankAccount()
        {

        }

        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public BankAccount(string accountNumber, decimal balance) : this(accountNumber)
        {
            Balance = balance;
        }
        #endregion

        #region Properties
        public string AccountNumber { get; set; }

        public decimal Balance
        {
            get
            {
                return _balance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("No negative blance");
                }
                _balance = value;
            }
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion

    }
}
