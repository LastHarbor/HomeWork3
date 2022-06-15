using System;
using System.Threading.Channels;

namespace HomeWork3._Exercise_3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число - ");
            int number = int.Parse(Console.ReadLine());
            int counter = 1;
            bool flag = false;
            

            while (counter < number - 1) //Счётчик чисел 
            {
                counter++;
                if (number % counter == 0 )   //Проверка условий согласно тз
                {
                    flag = true;
                    break;
                }
                else if(counter%number == 1)
                {
                    flag = false;
                    break;
                }
                
            }

            if (flag == false) Console.WriteLine("Число простое");
            else Console.WriteLine("Число с остатком");
            ;
            
            Console.ReadKey();
        }
    }
}
