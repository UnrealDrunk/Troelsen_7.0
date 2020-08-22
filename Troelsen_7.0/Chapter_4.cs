using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
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

        /// <summary>
        /// Демонстрация работа класса System.Array
        /// </summary>
        public void SystemArrayFunctionality()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("SystemArrayFunctionality");
            Console.WriteLine("=> Working with System.Array");
            //Инициализируем переменные
            string[] gothicBands = { "Tones of Tail", "Bauhaus", "Sisters of Mercy" };
            //выводим на печать данные в том порядке, в ктором мы их завели в массив

            Console.WriteLine("-> Here is the array: ");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");
            Array.Reverse(gothicBands);
            Console.WriteLine("-> The reversed array: ");
            //снова выводим данные. Но порядок вывода уже будет другой, т.к. сработал реверс.
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            //Вычищаем из массива все элементы кроме одного.

            Console.WriteLine("-> Cleared out all but one...");
            Array.Clear(gothicBands, 1, 2);

            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("");


        }

        /// <summary>
        /// Демонтсрация работы методов с использованием ключевого слова out
        /// </summary>
        public void ExecuteOutKeyword()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("ExecuteOutKeyword");
            // Нет необходимости инилиализировать локальные переменные для отображения выходных параметров
            // C#7 позволяет декларировать параметры непосредственно в вызове метода

            Add(90, 90, out int ans);
            Console.WriteLine("90 + 90 = {0}", ans);
            Console.WriteLine();
        }

        /// <summary>
        /// Метод суммирования с декларированием переменной, в котрой содержится результат непосредственно в с самом методе
        /// </summary>
        /// <param name="x">первая переменная</param>
        /// <param name="y">вторая переменная</param>
        /// <param name="ans">переменная, объявляемая в нутри метода, в которой хранится сумма</param>
        private static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }
        
        /// <summary>
        /// Демонтсрация передачи множественных значений с использованием метода  ключевым словом out
        /// </summary>
        public void ExecuteMultipleOutParams()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("ExecuteMultipleOutParams");

            int i; string str; bool b;
            FillThisValues(out i, out str, out b);
            Console.WriteLine("Int is: {0}", i);
            Console.WriteLine("String is: {0}", str);
            Console.WriteLine("Boolean is: {0}", b);
            Console.WriteLine();
        }

        /// <summary>
        /// Возвращет 3 переменных разного типа
        /// </summary>
        /// <param name="a"> целое число</param>
        /// <param name="b">строка</param>
        /// <param name="c">булева переменная</param>
        private static void FillThisValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string";
            c = true;
        }

        /// <summary>
        /// Демонстрация работы методов с ключевым словом  ref
        /// </summary>
        public void ExecuteSwapStrings()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("ExecuteSwapStrings");
            string s1 = "Flip";
            string s2 = "Flop";
            Console.WriteLine("Before: {0}, {1}", s1, s2);
            SwapStrings(ref s1, ref s2);
            Console.WriteLine("After: {0}, {1}", s1, s2);
            Console.WriteLine();
        }

        /// <summary>
        /// Метод обмена значениями между строками
        /// </summary>
        /// <param name="s1">первая (перменная) строка</param>
        /// <param name="s2">вторая (перменная) строка</param>
        private static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        /// <summary>
        /// Демонстрация неизменности массива при попытки внести изменения из вне
        /// </summary>
        public void RefLocalsAndParams1()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("RefLocalsAndParams1");
            string[] stringArray = { "one", "two", "three" };
            int pos = 1;
            Console.WriteLine("=> use simple return");
            Console.WriteLine("Before: {0}, {1}, {2}", stringArray[0], stringArray[1], stringArray[2]);
            var output = SimpleReturn1(stringArray, pos);
            output = "new";
            Console.WriteLine("After: {0}, {1}, {2}", stringArray[0], stringArray[1], stringArray[2]);
            Console.WriteLine();

        }

        /// <summary>
        /// Возвращение значения элемента метода
        /// </summary>
        /// <param name="strArray">передаваемый массив</param>
        /// <param name="position">индекс передаваемого массива</param>
        /// <returns></returns>
        private static string SimpleReturn1(string[] strArray, int position)
        {
            return strArray[position];
        }

        /// <summary>
        /// Демонтсрация изменения элемента массива за счет обращения к нему по ссылке
        /// </summary>
        public void RefLocalsAndParams2()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("RefLocalsAndParams2");
            string[] stringArray = { "one", "two", "three" };
            int pos = 1;
            Console.WriteLine("=> use Ref return");
            Console.WriteLine("Before: {0}, {1}, {2}", stringArray[0], stringArray[1], stringArray[2]);
            ref var refOutput = ref SimpleRefReturn(stringArray, pos);
            refOutput = "new";
            Console.WriteLine("After: {0}, {1}, {2}", stringArray[0], stringArray[1], stringArray[2]);
            Console.WriteLine();
        }

        /// <summary>
        /// Возвращения значения элемента метода по ссылке
        /// </summary>
        /// <param name="strArray">передаваемый массив</param>
        /// <param name="position">индекс массива</param>
        /// <returns></returns>
        private static ref string SimpleRefReturn(string[] strArray, int position)
        {
            return ref strArray[position];
        }

        /// <summary>
        /// Демонстрация различных способов вызова метода, где в передаваемом аргументе присутствует ключевое слово params
        /// </summary>
        public void ParamsArray()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("ParamsArray");
            //передаём список значений типа double разделенных запятой
            double average;
            average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("Average of dats is: {0}", average);

            // в следующем случае передаём массив, состоящий из элементов double
            double[] data = { 4.0, 3.2, 5.7 };
            average = CalculateAverage(data);
            Console.WriteLine("Average of dats is: {0}", average);

            //Или передаём  0
            Console.WriteLine("Average of dats is: {0}", CalculateAverage());
            Console.WriteLine();

        }


        /// <summary>
        /// Метод расчета средней величины из массива значений типа double
        /// </summary>
        /// <param name="values">ссылка на массив или список, разделенный запятой</param>
        /// <returns></returns>
        private static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles", values.Length);

            double sum = 0;
            if (values.Length == 0)
            {
                return sum;
            }

            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return sum / values.Length;
        
        }

        /// <summary>
        /// Демонстрация вызова методов с опциональным параметром
        /// </summary>
        public void ExecuteEnteringLogData_001()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("ExecuteEnteringLogData");
            EnterLogData_001("Oh no! Grid can't find data");
            EnterLogData_001("Oh no! I can't find my payroll data", "CFO");
            Console.WriteLine();
        }


        /// <summary>
        /// Метод для работы с вводом данных и демонстрацией работы опционального параметра
        /// </summary>
        /// <param name="message">текст сообщения</param>
        /// <param name="owner">имя пользователя</param>
        private static void EnterLogData_001(string message, string owner = "Programmer")
        {
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of error: {0}", owner);
        }

        /// <summary>
        /// Демонстрация вызова метода с ипользованием именованных параметров.
        /// </summary>
        public void ExecuteDisplayFancyMessages()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("ExecuteDisplayFancyMessages");
            DisplayFancyMethods(message: "Wow! Fancy, indeed!", textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);
            DisplayFancyMethods(message: "Teting...", textColor: ConsoleColor.Green, backgroundColor: ConsoleColor.DarkBlue);
            Console.WriteLine();

        }


        /// <summary>
        /// выводит на консоль сообщение с изменением цветовых решений
        /// </summary>
        /// <param name="textColor"> цвет текста</param>
        /// <param name="backgroundColor">цвет заднего фона</param>
        /// <param name="message">текст сообщения</param>
        private static void DisplayFancyMethods(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            // Запоминаем состояние цветов для того, чтобы восстановить их после завершения операции
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackroundColor = Console.BackgroundColor;

            //Устанавливаем новые цвета для вывода сообщения
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);

            //Восстанавливаем старые цвета после выполнения программы

            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackroundColor;
        }

        /// <summary>
        /// Демонстрация работы метода с использованием типа данных Enum
        /// </summary>
        public void ExecuteAskForBonus()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("ExecuteAskForBonus");
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);
            Console.WriteLine();
        }

        /// <summary>
        /// Хранит данные о должностях сотрудников
        /// </summary>
        private enum EmpType
        {
            Manager,
            Grunt,
            Contractor,
            VicePresident
        }

        /// <summary>
        /// Возвращает нужную фразу по тексту в соответствии с должностью
        /// </summary>
        /// <param name="e">должность сотрудника</param>
        private static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about to stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD? Sir!");
                    break;
               
            }
        }

        /// <summary>
        /// Демонтсрация возврата заднного типа перечисления
        /// </summary>
        public void AskForEnumTypeStorage()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("AskForEnumTypeStorage");
            //извлекаем тип Contractor

            EmpType emp = EmpType.Contractor;
            Console.WriteLine("EmpType uses a {0} for storage", Enum.GetUnderlyingType(emp.GetType()));
            Console.WriteLine("...");
            //Извлекаем тип Contractor с помощью typeof (другой вариант извлечениея)
            Console.WriteLine("EmpType uses a {0} for storage", Enum.GetUnderlyingType(typeof(EmpType)));
            Console.WriteLine();

        }

        /// <summary>
        /// Демонстрация наименования переменной перечислителя с помощью метода ToString()
        /// </summary>
        public void EmpToString()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("EmpToString");
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);

            //выводим в консоль сообщение о том, какая должность зшита в переменную emp

            Console.WriteLine("emp is a {0}", emp.ToString());
            Console.WriteLine();
        }

        /// <summary>
        /// Демонстрация возврата порядкового номера перечислителя
        /// </summary>
        public void DiscoverEnomerationGivenVariable()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("DiscoverEnomerationGivenVariable");
            EmpType emp = EmpType.Contractor;
            Console.WriteLine("{0} = {1}", emp.ToString(), (byte)emp);
            Console.WriteLine();

        }

        /// <summary>
        /// Демонтсрация вывода на печать всех пар "имя - значение" для перечислителя
        /// </summary>
        public void PrintEachNameValuePairWithinEnumeration()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("PrintEachNameValuePairWithinEnumeration");
            EmpType e2 = EmpType.Contractor;
            SetEachNameValuePairWithinEnumeration(e2);
            Console.WriteLine("...");
            DayOfWeek day = DayOfWeek.Monday;
            SetEachNameValuePairWithinEnumeration(day);
            Console.WriteLine("...");
            ConsoleColor cc = ConsoleColor.Gray;
            SetEachNameValuePairWithinEnumeration(cc);
            Console.WriteLine();

        }

        /// <summary>
        /// Формирование для вывода на печать пар "имя - значение" для перечислителя
        /// </summary>
        /// <param name="e">переменная перечислений</param>
        private static void SetEachNameValuePairWithinEnumeration(System.Enum e)
        {
            Console.WriteLine("=> Information about {0}", e.GetType().Name );
            Console.WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));
            // Получить все пары "имя - значение" для входящего параметра

            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members", enumData.Length);

            // Выводим имя строки и ассоциированный с ней номер, исользуя D формат
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
            }

        }

        /// <summary>
        /// Структура "точка"
        /// </summary>
        private struct Point
        {
            // Поля структуры
            public int X;
            public int Y;

            /// <summary>
            /// Кнструктор структуры "Точка"
            /// </summary>
            /// <param name="Xpos">Значение точки Х</param>
            /// <param name="Ypos">Значение точки Y</param>
            public Point(int Xpos, int Ypos)
            {
                X = Xpos;
                Y = Ypos;
            }

            /// <summary>
            /// Инкрементация точек
            /// </summary>
            public void Increment()
            {
                X++; Y++;
            }

            /// <summary>
            /// Декрементация точек
            /// </summary>
            public void Decrement()
            {
                X--; Y--;
            }

            /// <summary>
            /// Вывод информации на печать
            /// </summary>
            public void Display()
            {
                Console.WriteLine("X = {0}, Y = {1}", X, Y);
            }

        }

        /// <summary>
        /// Демонстрация работы с типом данных "Структура"
        /// </summary>
        public void ExecuteStructPoint()
        {
            //Инициализируем новую точку

            Console.WriteLine("Chapter 4");
            Console.WriteLine("ExecuteStructPoint");
            Point myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();

            //Перенанстроить параметры 
            myPoint.Increment();
            myPoint.Display();
            Console.WriteLine();

        }

        /// <summary>
        /// Демонстрация работы кастомного конструктора структуры
        /// </summary>
        public void ExecuteCustomStructPoint()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("ExecuteCustomStructPoint");
            Point p2 = new Point(50, 60);
            p2.Display();
            Console.WriteLine();
        }

        /// <summary>
        /// Демонтрация особенностей работы с разными экземплярами одной структуры. Особенности работы с памятью
        /// </summary>
        public void AssigningStructValueTypes()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("AssigningValueTypes");
            Point p1 = new Point(10, 10);
            Point p2 = p1;
            //выводим значения обеих структур на печать
            p1.Display();
            p2.Display();

            //Изменяем занчение p1
            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X \n");
            p1.Display();
            p2.Display();
            Console.WriteLine();

        }

        /// <summary>
        /// Класс "точка" 2D
        /// </summary>
        private class PointRef
        {
            // Поля класса
            public int X;
            public int Y;

            /// <summary>
            /// Кнструктор класса "Точка"
            /// </summary>
            /// <param name="Xpos">Значение точки Х</param>
            /// <param name="Ypos">Значение точки Y</param>
            public PointRef(int Xpos, int Ypos)
            {
                X = Xpos;
                Y = Ypos;
            }

            /// <summary>
            /// Инкрементация точек
            /// </summary>
            public void Increment()
            {
                X++; Y++;
            }

            /// <summary>
            /// Декрементация точек
            /// </summary>
            public void Decrement()
            {
                X--; Y--;
            }

            /// <summary>
            /// Вывод информации на печать
            /// </summary>
            public void Display()
            {
                Console.WriteLine("X = {0}, Y = {1}", X, Y);
            }
        }

        /// <summary>
        /// Демонтрация особенностей работы с разными экземплярами одного класса. Особенности работы с памятью
        /// </summary>
        public void ReferenceTypeAssigment()
        {
            Console.WriteLine("Chapter 4");
            Console.WriteLine("ReferenceTypeAssigment");
            PointRef p1 = new PointRef(10, 10);
            PointRef p2 = p1;
            //выводим значения обоих экземпляров класса на печать
            p1.Display();
            p2.Display();

            //Изменяем занчение экземпляра класса p1
            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X \n");
            p1.Display();
            p2.Display();
            Console.WriteLine();
        }





    }


}
