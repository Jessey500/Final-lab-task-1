using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_lab_task_1
{
    class Overdraft_Account:Account
    {
        
        int overdraftLimit = 0;

        public Overdraft_Account(string name, string accNo, double balance) : base(name, accNo, balance)
        {

        }
        override public void Deposit(double amount)
        {
            if (overdraftLimit>=1)
            {
                
                Console.WriteLine("Can't  Have More Than One OverDraft In A Month");
            }
            else
            {
                Balance = Balance + amount;
                overdraftLimit++;
            }
        }
        public override void Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
            }
            else
                Console.WriteLine("Insufficient Balance To Withdraw The Ammount");
        }
    }
}
