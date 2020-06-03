using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troelsen_7._0
{
    /// <summary>
    /// Демонстрация работы Switch(case)  на примере перечислений (энумераторов)
    /// </summary>
    public static class ExecuteTests
    {
        public static void SwitchOnEnumExample()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine("SwitchOnEnumExample");
            Console.Write("Enter your favorite day of the week: ");
            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                return;
            }

            switch (favDay)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Footbal!!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Anoter day, another dollar");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least it's not Monday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("A fine day");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost friday");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes, Friday rules!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Great day indeed/");
                    break;

            }
            Console.WriteLine();
        }

        /// <summary>
        /// Демонстрация проверки типа данных переменной с помощью Switch/Case
        /// </summary>
        public static void ExecutePatternMatchingSwitch()
        {
            Console.WriteLine("Chapter_3");
            Console.WriteLine("ExecutePatternMatchingSwitch");
            Console.WriteLine("1 [Integer(5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
            Console.WriteLine("PLease choose an option: ");
            string userChoise = Console.ReadLine();
            object choice;

            //Это стандартная константа переключения шаблонов для настройки примера
            switch (userChoise)
            {
                case "1":
                    choice = 5;
                    break;
                case "2":
                    choice = "Hi";
                    break;
                case "3":
                    choice = (decimal)2.5;
                    break;
                default:
                    choice = 5;
                    break;
            }

            //Это новый оператор переключения сопоставления с образцом

            switch (choice)
            {
                case int i:
                    Console.WriteLine("Your choice is an integer: {0}", i);
                    break;
                case string s:
                    Console.WriteLine("Your choice is a string: {0}", s);
                    break;
                case decimal d:
                    Console.WriteLine("Your choise is a decimal: {0}", d);
                    break;
                default:
                    Console.WriteLine("Your choise is something else");
                    break;
            }
            Console.WriteLine();





        }


    }

}
