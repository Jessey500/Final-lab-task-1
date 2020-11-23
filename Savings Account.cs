using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_lab_task_1
{
   abstract class Savings_Account:Account
    {
        public Savings_Account(string name, string id, double balance) : base(name,id,balance)
        {
        }
        public override void Withdraw(int withdraw)
        {
            if (withdraw >= 500)
            {
                if (withdraw <= Balance)
                {
                    Balance = Balance - withdraw;
                    Console.WriteLine("Withdraw balance");
                    Console.WriteLine("New balance " + Balance);
                }
                else
                {
                    Console.WriteLine("Balace is Less then " + withdraw);
                }
            }
            else
            {
                Console.WriteLine("Balance less than 500");
            }
        }
    }
}

