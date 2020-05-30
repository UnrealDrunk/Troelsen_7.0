using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

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

    }
}
