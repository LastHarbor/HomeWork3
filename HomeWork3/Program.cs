using System;
using System.Runtime.Intrinsics.Arm;

namespace HomeWork3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число - ");
            var num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) Console.WriteLine("Число чётное");
            else Console.WriteLine("Число нечётное") ;
        }
    }
}
