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

        /// <summary>
        /// Демонстрация различных способов инициализации массивов
        /// </summary>
        public void ArrayInitialization()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("ArrayInitialization");
            Console.WriteLine("=> Array initialization");
            //Инициализация нвого массива с использованием ключевого слова new

            string[] stringArray = new string[]
            {
                "one", "two", "three"
            };
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);

            //Инициализация нового массива без использования ключевого слова new

            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            //Инициализация массива с использованием ключевого слова new и указанием размера

            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);
            Console.WriteLine();

        }

        /// <summary>
        /// Демонстрация неявного определения типа массива в процессе инициализации
        /// </summary>
        public void DeclareImplicitlyArrays()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("DeclareImplicitlyArrays");
            Console.WriteLine("=> Implicit Array Initialization");

            //На самом деле массив с целыми числами
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a {0}", a.ToString());

            //На самом деле массив дробных чисел
            var b = new[] { 1, 2.5, 2, 3.5 };
            Console.WriteLine("b is a {0}",b.ToString());

            //На самом деле массив строк
            var c = new[] { "Hello", null, "World" };
            Console.WriteLine("c is a {0}", c.ToString());
            Console.WriteLine();
        }

    }
}
