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


    }
}
