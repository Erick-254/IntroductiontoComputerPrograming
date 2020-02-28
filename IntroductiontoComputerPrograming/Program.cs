using System;
using System.Linq;

namespace IntroductiontoComputerPrograming
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numbers;
            while (true)
            {
                Console.Write("How many number do you want to enter <2,10> : ");
                if (uint.TryParse(Console.ReadLine(), out numbers) && 2 < numbers && numbers < 10)
                    break;
                else Console.WriteLine("Try Again Now");
            }
              uint[] array = new uint[numbers];
              for (int i = 1; i <= numbers; i++)
                while (true)
                {
                    try
                    {
                        Console.Write("Enter number[" + i + "] = ");
                        array[i - 1] = uint.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Enter a valid integer");
                    }
                }
            uint maximumNumbers = array.Max();
            uint minimumNumbers = array.Min();
            Console.WriteLine("Max: " + maximumNumbers);
            Console.WriteLine("Min: " + minimumNumbers);
            Console.ReadLine();
        }
    }
}
