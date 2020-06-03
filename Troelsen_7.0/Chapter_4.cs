using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troelsen_7._0
{
    /// <summary>
    /// Класс описывающий программы главы 3 книги Троельсена
    /// </summary>
    public class Chapter_4
    {
        /// <summary>
        /// Демонстрация создания и заполнения массива целых чисел
        /// </summary>
        public void SimpleArrays()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("SimpleArrays");

            Console.WriteLine("=> Simple Array creation");

            // Создаём и заполняем маасив из 3х целых чисел
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            //Выводим заполненный массив в консоль
            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

    }
}
