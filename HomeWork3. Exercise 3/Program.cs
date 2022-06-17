using System;
using System.Threading.Channels;

namespace HomeWork3._Exercise_3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите число - ");
            int number = int.Parse(Console.ReadLine());
            int counter = 1;
            bool isPrime = true;
            

            while (counter < number - 1) //Счётчик чисел 
            {
                counter++;
                if (number % counter == 0 ) //Проверка условий согласно тз
                {
                    isPrime = false;
                    break;
                }

            }

            Console.WriteLine($"Количество итераций - {counter}\n ");

            if (isPrime) Console.WriteLine("Число простое");
            
            else Console.WriteLine("Число с остатком");
            
            
            Console.ReadKey();
        }
    }
}
