using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Multiplication.MultiplyNums();
            Addition.AddNums();
            Subtraction.SubNums();
            Division.DivNums();
        }


        public class Multiplication
        {

            public static void MultiplyNums()
            {
                Console.WriteLine("Enter a number");
                float num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter another number");
                float num2 = float.Parse(Console.ReadLine());

                Console.WriteLine($"{num1} x {num2} = {num1 * num2}");

                Console.WriteLine("Press Enter to proceed to next question");
                Console.ReadLine();
            }
        }
    }

    public class Math
    {
        public float MultiplyNumsNew(float _num1, float _num2)
        {
            return _num1 * _num2;

        }
    }

    public class Addition
        {
                      
              public static void AddNums()
             {
                    Console.WriteLine("Enter a number");
                    float num1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter another number");
                    float num2 = float.Parse(Console.ReadLine());

                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

                    Console.WriteLine("Press Enter to proceed to next question");
                    Console.ReadLine();
             }

        }
    
        public class Subtraction
    {

              public static void SubNums()
             {

                    Console.WriteLine("Enter a number");
                    float num1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter another number");
                    float num2 = float.Parse(Console.ReadLine());

                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");

                    Console.WriteLine("Press Enter to proceed to next question");
                    Console.ReadLine();
        }

    }

        public class Division
    {

              public static void DivNums()
             {

                    Console.WriteLine("Enter a number");
                    float num1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter another number");
                    float num2 = float.Parse(Console.ReadLine());

                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");

                    Console.WriteLine("End of Task 1");
                    Console.ReadLine();
        }

    }

}
        