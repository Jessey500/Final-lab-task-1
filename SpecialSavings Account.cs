using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_lab_task_1
{
    class SpecialSavings_Account:Account
    {
        
        int transaction = 0;
        int minimalNo = 4;

        public void SpecialSavings_Account(string name, string accNo, double balance) : base(name, accNo, balance)
        {
        }

        override public void Deposit(double amount)
        {

            if (transaction >= minimalNo)
            {
                Console.WriteLine("Can't More Transaction In This Month.");
            }
            else
            {
                Balance = Balance + amount;
                transaction++;
            }

        }
        
        public override void Withdraw(double amount)
        {

            if (Balance - amount >= Balance*0.2)
            {
                Balance -= amount;
            }
            else
                Console.WriteLine("Withdraw Balance Must Be Minimum 20% Of Openning Balance");
        }
    }
}
