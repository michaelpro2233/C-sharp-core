using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Arrays *****");
            SimpleArrays();
            Console.ReadLine();
        }

        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Collection.");
            //Создать массив int, содержащий 3 элемента с индексами 0, 1, 2.
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            //Вывести все значения
            foreach(int i in myInts)
                Console.WriteLine(i);
            Console.WriteLine();

            //Создать массив string, содержащий 100 элементов с индексами 0 - 99.
            string[] booksOnDotNet = new string[100];
            Console.WriteLine();
        }
    }
}
