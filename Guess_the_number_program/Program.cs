using System;
using System.Text;
using System.Diagnostics;

class Program
{

    static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch(); //Время 

        sw.Start(); // Старт таймера

        int a, min = 1, max = 1000, attempt = 1;
        Random rnd = new Random();  // Создаем переменную рандомного числа
        int num = rnd.Next(1, 1001); // Рандомное число будет от 1 до 1001
        //Console.WriteLine(num);
        

        Console.WriteLine("Давай сыграем в игру 'угадай число' :)");
        Console.WriteLine("Введите число от 1 до 1000");
        string str = Console.ReadLine();
        a = Int32.Parse(str);
        
        while (a != num)
        {
            attempt++;
            //Console.Write("Введите число: ");
            //string str = Console.ReadLine();
            //a = Int32.Parse(str);

            /* try
            {
                a = Int32.Parse(str);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка, введено не число");
            }
            */
            if (a < num)
            {
                min = a;
                
                Console.WriteLine("Введите число от {0} до {1}", min, max);
                str = Console.ReadLine();
                a = Int32.Parse(str);

            }
            else
            {
                max = a;

                Console.WriteLine("Введите число от {1} до {0}", max, min);
                str = Console.ReadLine();
                a = Int32.Parse(str);
            }
        sw.Stop();
        }
        if (a == num)
        {
            Console.WriteLine("Молодец, ты угадал число :)");
            Console.WriteLine("Вы угадали число за: {0} попыток", attempt);

            TimeSpan ts = sw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
            ts.Hours, ts.Minutes, ts.Seconds);

            Console.WriteLine("Затраченное время : " + elapsedTime + "секунд");
        }

        Console.WriteLine("Press any key to continue...");
        //pause - задержка экрана - пока пользователь не нажмет любую клавишу
        Console.ReadKey();
    }

}
