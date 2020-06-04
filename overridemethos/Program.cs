using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridemethos
{
    class Program
    {
        static int Power(int input)
        {
            return (int)Math.Pow(input, 2);
        }
        static int Power(int input, int count)
        {
            return (int)Math.Pow(input, count);
        }
        static int SumAll(int end)
        {
            int result = 0;
            for (int i = 0; i < end; i++)
            {
                result += i;
            }
            return result;
        }
        static int SumAll(int start, int end)
        {
            int result = 0;
            for (int i = start; i < end; i++)
            {
                result += i;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Power(2));
            Console.WriteLine(Power(2, 3));
            Console.WriteLine(SumAll(3));
            Console.WriteLine(SumAll(1, 4));

        }
    }
}

