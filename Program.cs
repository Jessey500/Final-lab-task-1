using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_lab_task_1
{
    class Program
    {
        static void Main(string[] args)
        {  //name,id,balance,monthly transaction
            Savings s = new Savings("Rakhi", 19399791, 12000, 4);
            s.Showinfo();
            s.withdrawing(500);
            Console.WriteLine();

            //name,id,balance,creat year,tenure
            Fixed f = new Fixed("Rahman", 19393421, 10000, 2018, 5);
            f.Showinfo();
            f.withdrawing(300);
            Console.WriteLine();

            //Not mature
            Fixed f1 = new Fixed("Tanusri", 765, 5000, 2017, 6);
            f1.Showinfo();
            f1.withdrawing(300);
            Console.WriteLine();

            SpecialSavings s1 = new SpecialSavings("Rakhi", 19399791, 12000, 4);
            s1.Showinfo();
            s1.withdrawing(500);
            Console.WriteLine();

            ///will not withdraw
            SpecialSavings s2 = new SpecialSavings("Karim", 19399821, 10000, 3);
            s2.Showinfo();
            s2.withdrawing(2000);
            Console.WriteLine();

            OverDraft o = new OverDraft("Karim", 19399821, 10000, 3);
            o.Showinfo();
            o.withdrawing(200);
            Console.WriteLine();


        }
    }
}