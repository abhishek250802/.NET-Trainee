using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Trainee;

namespace Trainee
{
    public class BankAccount
    {
    //     // Variables (#1)
    //public string Number { get; }
    //public string Owner { get; set; }
    //public decimal Balance { get; }

    //// Constructor (#2)
    //public BankAccount(string name, decimal initialBalance)
    //{
    //    this.Owner = name;
    //    this.Balance = initialBalance;
    //}

    //// Functions (#4)
    //public void MakeDeposit(decimal amount, DateTime date, string note)
    //{
    //}

    //public void MakeWithdrawal(decimal amount, DateTime date, string note)
    //{
    //}
    //}
     // Properties
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance { get; }
    //(Paste first bit here!)

    // Constructor
    public BankAccount(string name, decimal initialBalance)
    {
        this.Owner = name;
        this.Balance = initialBalance;
        //(Paste second part here!)

    }

    // Functions
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
    }
    } 
    }


//Update BankAccount to match{
    // Properties
    //public string Number { get; }
    //public string Owner { get; set; }
    //public decimal Balance{ get;}
    //private static int accountNumberSeed = 1234567890;
    ////(Paste here!)

    //// Constructor
    //public BankAccount(string name, decimal initialBalance)
    //{
    //    this.Owner = name;
    //    this.Balance = initialBalance;
    //    this.Number = accountNumberSeed.ToString();
    //    accountNumberSeed++;

    //}

    //// Functions
    //public void MakeDeposit(decimal amount, DateTime date, string note)
    //{
    //}

//    public void MakeWithdrawal(decimal amount, DateTime date, string note)
//    {
//    }
//}
//Initial balance
// public string Number { get; }
//    public string Owner { get; set; }
//    public decimal Balance  //(#5)
//    {
//        get

//        {
//            decimal balance = 0;
//            foreach (var item in allTransactions)
//            {
//                balance += item.Amount;
//            }

//            return balance;
//        }


//    }
//    private static int accountNumberSeed = 1234567890; //(#1)
//    private List<Transaction> allTransactions = new List<Transaction>(); //(#4)


//    // Constructor
//    public BankAccount(string name, decimal initialBalance)
//    {
//        this.Owner = name;
//        //(#6: deleted "this.Balance = initialBalance;")
//        this.Number = accountNumberSeed.ToString(); //(#1)
//        accountNumberSeed++; //(#1)

//    }

//    // Functions
//    public void MakeDeposit(decimal amount, DateTime date, string note)
//    {
//    }

//    public void MakeWithdrawal(decimal amount, DateTime date, string note)
//    {
//    }
//}