using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Troelsen_7._0
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecutePrograms();
        }

        /// <summary>
        /// Контроль исполнения программы
        /// </summary>
        private static void ExecutePrograms()
        {
            ChapterSelector();
            bool IsExecuted = false;
            while (!IsExecuted)
            {
                Console.WriteLine("Продолжить выполнение прграммы?");
                Console.Write("1 - ДА; 2 - НЕТ; ваш выбор?: ");
                bool IsNumber = false;
                int choiceSelector = 0;
                while (!IsNumber)
                {
                    if (Int32.TryParse(Console.ReadLine(), out choiceSelector))
                    {
                        IsNumber = true;
                    }
                    else
                    {
                        Console.Write("Некорректный ввод данных, требуется ввести 1 или 2. Попробуйте ещё раз: ");
                    }

                    switch (choiceSelector)
                    {
                        case 1:
                            Console.WriteLine("Программа продолажет работу");
                            Console.Clear();
                            Console.WriteLine("Консоль очищена");
                            ChapterSelector();
                            break;
                        case 2:
                            Console.WriteLine("Программа прекарщает работу");
                            IsExecuted = true;
                            break;
                        default:
                            Console.WriteLine("Некорректный ввод данных, требуется ввести 1 или 2. Попробуйте ещё раз.");
                            break;
                    }
                }
            }
        }


        /// <summary>
        /// Механизм выбора главы
        /// </summary>
        private static void ChapterSelector()
        {
            Console.WriteLine("Выберите главу для демонстрации работы содеражщихся в ней программ: \n" +
                "для выбора главы 3 нажмите цифру 3");
            Console.Write("Ваш выбор?: ");
            bool IsSelected = false;

            while (!IsSelected)
            {
                int chapterSelector = 0;
                bool IsNumber = false;
                while (!IsNumber)
                {
                    if (Int32.TryParse(Console.ReadLine(), out chapterSelector))
                    {
                        IsNumber = true;
                    }
                    else
                    {
                        Console.Write("Некорректный ввод данных, требуется ввести число, попробуйте ещё раз: ");
                    }
                }

                switch (chapterSelector)
                {
                    case 3:
                        RunChapterThree();
                        IsSelected = true;
                        break;
                    default:
                        Console.Write("Некорректный ввод данных, попробуйте ещё раз: ");
                        break;
                }

            }
        }

        /// <summary>
        /// Запуск программ, содеержащихся в главе 3
        /// </summary>
        private static void RunChapterThree()
        {
            // Модуль управления главой 3

            Chapter_3 chapter_3 = new Chapter_3();
            chapter_3.ObjectFunctionality();
            chapter_3.DataTypeFunctionality();
            chapter_3.MembersOfSystemBolean();
            chapter_3.CharFunctionality();
            chapter_3.ParseFromStrings();
            chapter_3.ParseFromStringsWithTryParse();
            chapter_3.UseDatesAndTimes();
            chapter_3.UseBigIntegers();
            chapter_3.DidgitSeparators();
            chapter_3.BasicStringFunctionality();
            chapter_3.StringConcatenation();
            chapter_3.StringConcatenationWConcat();
            chapter_3.EscapeChars();
            chapter_3.StringEquality();
            chapter_3.StringEqualitySpecifyingCompareRules();
            chapter_3.StrigsAreImmutable();
            chapter_3.FunWithStringBuilder();
            chapter_3.StringInterpolation();
            chapter_3.NarrowingAttemptWithLoss();
            chapter_3.NarrowingAttemptWihoutLoss();
            chapter_3.ProcessBytes();
            chapter_3.DeclareVarsImplictVars();
            chapter_3.LinqQueryOverInts();
            chapter_3.ForLoopExample();
            chapter_3.ForeachLoopExample();
            chapter_3.WhileLoopExample();
            chapter_3.DoWhileLoopExample();
            chapter_3.IfElseExample();
            //



        }


    }
}
