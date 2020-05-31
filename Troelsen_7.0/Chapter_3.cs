using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.Remoting.Messaging;

namespace Troelsen_7._0
{
    /// <summary>
    /// Класс описывающий программы главы 3 книги Троельсена
    /// </summary>
    public  class Chapter_3
    {
        /// <summary>
        /// Демонстрация работы псевдонимов объекта и сокращенных наименований
        /// </summary>
        public  void ObjectFunctionality()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine("=> System.Object Functionality \n");

            // C # int на самом деле является сокращением для System.Int32,
            // который наследует следующие члены из System.Object.

            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
        }

        /// <summary>
        /// Демонстрация функциональности типов данных
        /// </summary>
        public void DataTypeFunctionality()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine(" Max of int: {0}", int.MaxValue);
            Console.WriteLine(" Min of int: {0}", int.MinValue);
            Console.WriteLine(" Max of double: {0}", double.MaxValue);
            Console.WriteLine(" Min of double: {0}", double.MinValue);
            Console.WriteLine(" double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine(" double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine(" double.NegativeInfinity: {0}", double.NegativeInfinity);
            Console.WriteLine();

        }


        /// <summary>
        /// Демонтрация работы булевых переменных
        /// </summary>
        public void MembersOfSystemBolean()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
            Console.WriteLine();

        }


        /// <summary>
        /// Демонстрация работы типа данных Char
        /// </summary>
        public void CharFunctionality()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine("=> char type functionality");
            char myChar = 'a';
            Console.WriteLine("char.IsDidgit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello there', 5): {0}", char.IsWhiteSpace("Hello there", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello there', 6): {0}", char.IsWhiteSpace("Hello there", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
            Console.WriteLine();

        }

        /// <summary>
        /// Демонстрация парсинга даных из строк
        /// </summary>
        public void ParseFromStrings()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine(" => Data type parsing");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);
            double d = double.Parse("99,884");
            Console.WriteLine("Value of d: {0}", d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);
            char c = char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);
            Console.WriteLine();

        }

        /// <summary>
        /// Демонтстрация работы метода TryParse
        /// </summary>
        public void ParseFromStringsWithTryParse()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine("=> Data types parsing with TryParse: ");
            if (bool.TryParse("True", out bool b))
            {
                Console.WriteLine("Value of b: {0}", b);
            }

            string value = "Hello";
            if (double.TryParse(value, out double d))
            {
                Console.WriteLine("Value of d: {0}", d);

            }
            else
            {
                Console.WriteLine("Failed to convert the input ({0}) to a double", value);
            }
            Console.WriteLine();
        }


        /// <summary>
        /// Демонстрация методов обработки даты и времени
        /// </summary>
        public void UseDatesAndTimes()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine("=> Dates and times");

            //Конструктор принимает парметры - (год, месяц, дата)
            DateTime dt = new DateTime(2015, 10, 17);

            //Какой сейчас день недели?
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

            //Добавляем ещё 2 месяца к текущей дате и получается, что текущий месяц - Декабрь
            dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

            //Конструктор принимает парметры - (часы, мниуты, секунды)
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);

            // Вычитаем 15 минут из текущего времени и выводим результат на экран
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
            Console.WriteLine();
        }

        /// <summary>
        /// Демонтрация работы с классом огромных чисел - BigInteger
        /// </summary>
        public void UseBigIntegers()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine("=> Use BigInteger");
            BigInteger biggy = BigInteger.Parse("9999999999999999999999999999999999999999999999");
            Console.WriteLine("Value of biggy is {0}", biggy);
            Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
            Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
            BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("8888888888888888888888888888888888888888888"));
            Console.WriteLine("Value of reallyBig is {0}", reallyBig);
            Console.WriteLine();

        }

        
      
        /// <summary>
        /// Демонстрация работы числовых разделителей
        /// </summary>
        public void DidgitSeparators()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine("=> Use Didgit Separators");
            Console.WriteLine("Integer: ");
            Console.WriteLine(123_456);
            Console.WriteLine("Long: ");
            Console.WriteLine("123_456_789L");
            Console.WriteLine("Float: ");
            Console.WriteLine("123_456.1234f");
            Console.WriteLine("Double: ");
            Console.WriteLine("123_456.12");
            Console.WriteLine("Decimal");
            Console.WriteLine("123_456M");
            Console.WriteLine();
        
        }

        /// <summary>
        /// Демонстрация базовойфункцональности строковых типов данных
        /// </summary>
        public void BasicStringFunctionality()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine("=> Basic String Functionality: ");
            string firstName = "Freddy";
            Console.WriteLine("Value of first nsame is {0}", firstName);
            Console.WriteLine("first name has {0} characters.", firstName.Length);
            Console.WriteLine("first name in upper case: {0}", firstName.ToUpper());
            Console.WriteLine("first name in lower case: {0}", firstName.ToLower());
            Console.WriteLine("first name contains the letter 'y'? {0}", firstName.Contains("y"));
            Console.WriteLine("first name after replace: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();

        }

        /// <summary>
        /// Демонтсрация работы конкатенации (сложения строк)
        /// </summary>
        public void StringConcatenation()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine("=> String Concatenation");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine();
        }

        /// <summary>
        /// Демонстрация работы канкатенации с помощью статического метода String.Concat()
        /// </summary>
        public void StringConcatenationWConcat()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine("=> String Concatenation with String.Concat");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string s3 = String.Concat(s1, s2);
            Console.WriteLine(s3);
            Console.WriteLine();
        }

        /// <summary>
        /// Демонстрация работы Escape - последовательностей
        /// </summary>
        public void EscapeChars()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine("=> Escape characters: ");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a";
            Console.WriteLine(strWithTabs);

            Console.WriteLine("Everyone loves \"Hello World\"\a");
            Console.WriteLine(@"C:\MyApp\bin\debug");
            Console.WriteLine("All finished. \n\n\n\a");
            Console.WriteLine();
        }

        /// <summary>
        /// Демонстрация проверки строк на равнество (соответствие по содержанию)
        /// </summary>
        public void StringEquality()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine("=> String equality: ");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            //тест строк на равенство (соотвествтие друг другу по содержанию)
            Console.WriteLine("s1 == s2: {0}", s1==s2);
            Console.WriteLine("s1 = Hello!: {0}", s1=="Hello!");
            Console.WriteLine("s1 = HELLO!: {0}", s1=="HELLO!");
            Console.WriteLine("s1 = hello!: {0}", s1=="hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine();


        }

        /// <summary>
        /// Специальные методы сравнения строк
        /// </summary>
        public void StringEqualitySpecifyingCompareRules()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine("=> String equality (Case Insensitive: )");
            string s1 = "Hello!";
            string s2 = "HELLO!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            //Проверьте результаты изменения правил сравнения по умолчанию.

            Console.WriteLine("Default reles: s1 = {0}, s2 = {1}s1.Equals(s2): {2}", s1, s2, s1.Equals(s2));
            Console.WriteLine("Ignore case: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}",
                s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case, Invariant culture:" +
                " s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}",
               s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine();
            Console.WriteLine("Default rules: s1 = {0}, s2 = {1} s1.IndexOf(\"E\"): {2}", s1, s2, s1.IndexOf("E"));
            Console.WriteLine("Ignore case: s1 = {0}, s2 = {1} " +
                "s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase): {2}",
                s1, s2, s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case, Invariant culture: s1 = {0}, s2 = {1} " +
               "s1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase): {2}",
               s1, s2, s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine();
        }

        /// <summary>
        /// Метод демонстрирующий неизменность значений строк несмотря на манипуляции с размером шрифта
        /// </summary>
        public void StrigsAreImmutable()
        {
            Console.WriteLine("Chapter_3");
            //Инициализируем новую строку
            string s1 = "This is my string";
            Console.WriteLine("s1 = {0}", s1);

            //Увеличиваем шрифт
            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);

            // Однако строка s1 останется в исходном формате

            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine();

            string s2 = "My other string";
            Console.WriteLine("s2 = {0}", s2);
            s2 = "New string s2 value";
            Console.WriteLine("s2 = {0}", s2);
        }

        /// <summary>
        /// Демонтрация работы класса StringBuilder
        /// </summary>
        public void FunWithStringBuilder()
        {
            Console.WriteLine("Chapter_3");
            StringBuilder stringBuilder = new StringBuilder("****Fantastic Games****");
            stringBuilder.Append("\n");
            stringBuilder.Append("Half Life ");
            stringBuilder.Append("Morrowind ");
            stringBuilder.Append("Deus Ex" + " 2 ");
            stringBuilder.Append("System Shock ");
            Console.WriteLine(stringBuilder.ToString());
            stringBuilder.Replace("2", "Invisble War");
            Console.WriteLine(stringBuilder.ToString());
            Console.WriteLine("stringBuilder has {0} chars", stringBuilder.Length);
            Console.WriteLine();

        }

        /// <summary>
        /// Демонтсрация ввода текстовых данных методом интерполяции
        /// </summary>
        public void StringInterpolation()
        {
            Console.WriteLine("Chapter_3");
            // Локальные переменные, которые будут встроены в строковый тип данных
            int age = 4;
            string name = "Soren";

            // Для вывода строки используем синтакис с фигурными скобками
            string greeting = string.Format("Hello, {0}, you are {1} years old.", name, age);

            // Применение интерполяции
            string greeting2 = $"Hello, {name}, you are {age}, years old.";

            Console.WriteLine(greeting + "\n" +greeting2);
            Console.WriteLine();
        }

        /// <summary>
        /// Демонстрация работы явного приведения данных с потерей данных
        /// </summary>
        public void NarrowingAttemptWithLoss()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine("****Fun with type conversions****");
            short numb1 = 30000, numb2 = 30000;

            // Явное приведение данных типа int к типу short с потерей данных
            short answer = (short)AddSum(numb1, numb2);
            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);
            Console.WriteLine();
        }

        /// <summary>
        /// Вспомогательный метод для суммирования 2х чисел
        /// </summary>
        /// <param name="x">первое число</param>
        /// <param name="y">воторое число</param>
        /// <returns>сумма двух чисел</returns>
        private static int AddSum(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Демонтсрация работы явного привдения типов данных с потерей данных
        /// </summary>
        public void NarrowingAttemptWihoutLoss()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine("****Fun with type conversions****");
            byte myByte = 0;
            int myInt = 200;
            //Явное приведение типов данных без потреи информации
            myByte = (byte)myInt;
            Console.WriteLine("Value of myByte: {0}", myByte);
            Console.WriteLine();
        }

        /// <summary>
        /// Демонстрация работы исключительной ситуациии при переполнении данных
        /// </summary>
        public void ProcessBytes()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine("Работа с отлавливанием ошибки при перевыполнении ");
            
            byte b1 = 100;
            byte b2 = 250;

            //перехват исключения при переполнении памяти при выполнении операции

            try
            {
                checked
                {
                    byte sum = (byte)AddSum(b1, b2);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
