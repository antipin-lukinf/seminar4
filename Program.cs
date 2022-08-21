using System;

namespace ConsoleApp1
{
    class Program
    {
        /*static void ReadNumber(int number)             //создание функции ReadNumber(входящие значения int, входящая переменная number)
        {
            Console.WriteLine(number * number);
        }*/

         static int PowTwoNumber(int number)             //создание функции ReadNumber(входящие значения int, входящая переменная number)
        {
            return number * number;
        }

        static string MultipleTwoNumber(int number)                 //функция определяет кратное число или нет
        {
            return number % 2 == 0 ? "Кратное" : "Не кратное";

        }

        static int[] Shuffle(int[] array)
        {
            for(int i = 0; i<array.Length-1; i++)
            {
                int j = new Random().Next(0, i = 1);
                int tmp = array[i];
                array[i] = array[j];
                array[j] = tmp;

            }
            return array;
        }
        static int[] CreaterArray(int number)
        {
            int[] array = new int[number];
            for(int i = 0; i< array.Length; i++)
            {
                array[i] = i + 1;
            }
            return array;
        }
        static void WriteArray(int[] array)
        {
            Console.Write("Вывод массива");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            //int number = Convert.ToInt32(Console.ReadLine());
           // ReadNumber(number);
            //Console.WriteLine(PowTwoNumber(number));
            //Console.WriteLine(MultipleTwoNumber(PowTwoNumber(number)));  //вызов функции в функции
            int[] array = CreaterArray(30);
            WriteArray(array);
            //array = Shuffle(array);
            WriteArray(Shuffle(array));
            //ReadNumber(10);                        //вызов функции ReadNumber, со значением number = 10
           //ReadNumber(Convert.ToInt32(Console.ReadLine()));        //вызов функции ReadNumber, с вводом number с клавиатуры

        }
    }
}
