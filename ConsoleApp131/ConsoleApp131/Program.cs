using System;

namespace ConsoleApp131
{
    class Program
    {
        static void Main(string[] args)
        {

            //1

            int zeroCounter = 0;
            double sum = 0;
            double mult = 1;
            Random rand = new Random();

            double[,] arr = new double[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i, j] = rand.Next(-10, 10);
                }
            }

            foreach (double num in arr)
            {
                if (sum > 0)
                {
                    sum += num;
                }
                else if (num < 0)
                {
                    mult *= num;
                }
                else if (num == 0)
                {
                    zeroCounter++;
                }
            }
            Console.WriteLine($"\nКоличество положительных чисел: {sum}\n Количество отрицательных чисел: {mult}\nКоличество нулей: {zeroCounter}");


            //2
            Console.WriteLine("Введите число");
            int x = Int32.Parse(Console.ReadLine());
            int count = 0;
            while (x != 0)
            {
                count++;
                x /= 10;
            }
            Console.WriteLine("Длина числа: " + count + " цифр.");

            //4
            Console.Write("Введите число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());

            if (a != 0 && b != 0) 
            {
                if (a % b == 0 || b % a == 0)
                {
                    Console.WriteLine("Да, одно из чисел является делителем другого.");
                }
                else
                {
                    Console.WriteLine("Нет, ни одно из чисел не является делителем другого.");
                }
            }
            else
            {
                Console.WriteLine("Хотя бы одно из чисел равно нулю. Невозможно определить делители.");
            }


            //5
            Console.Write("Введите значение поворота часовой стрелки в градусаъ: "); 
            double degrees = double.Parse(Console.ReadLine());
            double hours = degrees / 30; 
            double minutes = (hours - Math.Floor(hours)) * 60;
            
            int roundedHours = (int)Math.Floor(hours); 
            int roundedMinutes = (int)Math.Round(minutes, MidpointRounding.ToEven);

            Console.WriteLine($"С начала суток прошло {roundedHours} час(а/ов) и {roundedMinutes} минут(а/ы).");

        }
    }
}
