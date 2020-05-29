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
        }

    }
}
