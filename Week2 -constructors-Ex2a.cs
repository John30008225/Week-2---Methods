using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person1 employee1 = new Person1("","",0,0,"");

            Console.WriteLine("Enter a first name");
            employee1.Fname = Console.ReadLine();
            Console.WriteLine("Enter a last name");
            employee1.Lname = Console.ReadLine();
            Console.WriteLine("Enter Pay Rate");
            employee1.Payrate = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Tax % Rate");
            employee1.Tax = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account Number");
            employee1.Acc = Console.ReadLine();

            Console.ReadLine();
            employee1.Fname = "";
            Console.WriteLine(employee1.Fname);
            Console.ReadLine();
        }

       
    }
}
