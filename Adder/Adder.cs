using System;

namespace Adder
{
    class Adder
    {
        static void Main(string[] args)
        {
            //Переменная суммы
            int sum = 0;

            //Цикл суммирования аргументов
            for (int i = 0; i < args.Length; i++)
            {
                //Временная переменная, для преобразования аргумента из типа string в int
                int buf;

                //Преобразование аргумента
                buf = System.Convert.ToInt32(args[i]);

                //Суммирование
                sum += buf;
            }

            //Вывод результата и ожидание нажатия любой клавиши для завершения программы
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
