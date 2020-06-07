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

        /// <summary>
        /// Демонстрация работы массива, состоящего из данных типа Object
        /// </summary>
        public void ArrayOfObjects()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("ArrayOfObjects");
            Console.WriteLine("=> Array of Objects");

            //Массив типа данных Object может содержать всё что угодно
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";
            foreach (object obj in myObjects)
            {
                //Выводим в консоль значение и тип каждого объекта
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Демонстрация работы с двумерным массивом
        /// </summary>
        public void RectMultidimensionalArray()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("RectMultidimensionalArray");
            Console.WriteLine("=> Rectangular multidimensional array");
            // Двумерный массив

            int[,] myMatrix;
            myMatrix = new int[3, 4];

            // Формируем и автоматически заполняем матрицу 3*4
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    myMatrix[i, j] = i * j;
                }
            }

            //выводим в консоль сформированную матрицу

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Демонстрация работы зубчатого массива (массива массивов)
        /// </summary>
        public void JaggedMultidimensionalArray()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("JaggedMultidimensionalArray");
            Console.WriteLine("=> Jagged multidimensional array");

            //Зубчатый массив, или массив массивов
            //В рассматриваемом примере - массив состоящий из пяти различных массивов

            int[][] myJagArray = new int[5][];

            //Создаём зубчатый массив
            for (int i = 0; i < myJagArray.Length; i++)
            {
                myJagArray[i] = new int[i + 7];
            }

            //Выводим массив в консоль. Внимание, каждый элемент по умолчанию равен нулю

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                {
                    Console.Write(myJagArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Демонтстация, как массив может выступать в качестве передаваемых аргументов и в качестве возвращаемых значений
        /// </summary>
        public void PassAndRecieveArrays()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("PassAndRecieveArrats");
            // Передаём массив в качестве параметра
            int[] ages = { 20, 22, 23, 0 };
            PrintArray(ages);

            //Вовзращаем массив как значение
            string[] strs = GetStringArray();
            foreach (string s in strs)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Вывод числового массива на печать в косноль
        /// </summary>
        /// <param name="myInts">массив целых чисел</param>
        private static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
            {
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
            }
        }

        /// <summary>
        /// Возвращает массив строк
        /// </summary>
        /// <returns>массив строк</returns>
        private string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            return theStrings;
        }

    }


}
