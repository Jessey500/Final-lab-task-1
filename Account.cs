using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_lab_task_1
{
    abstract class Account
    {
        public string Name { get; set; }
        public string AccNo { get; set; }
        public double Balance { get; set; }

        public Account(string name, string accNo,double balance)
        {
            Name = name;
            AccNo = accNo;
            Balance = balance;
          
        }

        abstract public void ShowInfo();
        
        public abstract void withdraw(int withdraw);

        abstract public void Fixed();
        abstract public void SpecialSaving();
        abstract public void Overdraft();

    }
}
