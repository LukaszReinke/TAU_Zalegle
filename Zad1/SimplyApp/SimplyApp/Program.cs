using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi!");
            
        }

        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public int SubtractNumbers(int a, int b)
        {
            return a - b;
        }

        public int MultiplyNumbers(int a, int b)
        {
            return a * b;
        }

        public int DivideNumbers(int a, int b)
        {
            return a / b;
        }
    }
}
