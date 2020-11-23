using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_lab_task_1
{
        class Fixed_Account:Account
    {   
        public int CreateYear { get; set; }
        public int TenureYear { get; set; }

        
        public Fixed_Account(string name,string accNo,double balance, int createYear, int tenureYear):base(name,accNo,balance)
        {
            CreateYear = createYear;
            TenureYear = tenureYear;
        }
       
         abstract public void Withdraw(double amount)
        {
            int currentYr = DateTime.Now.Year;
            if(currentYr-CreateYear>=TenureYear)
            {
                Balance -= amount;
            }
            else
                Console.WriteLine("Account is not matured enough");
        }
        public new void ShowInfo()
        {
        
            Console.WriteLine("Create Year: "+CreateYear);
            Console.WriteLine("Tenure Year: "+TenureYear);
            Console.WriteLine("Current Year: " + DateTime.Now);

        } 
    }
}
