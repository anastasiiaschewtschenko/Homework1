using System.Net.Http.Headers;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Здравуйствуйте, это мой калькуЛятор!\nKакие операции Вы бы хотели произвести?");
            start:
            Console.WriteLine("1 Сложение\n2 Вычитание \n3 Деление \n4 Умножение \n5 Процент от числа \n6 Квадратный корень числа\n7 Выход");

            int choose = int.Parse(Console.ReadLine());

             switch (choose)
            {
                case 1:
                    Console.WriteLine("Введите число номер 1:");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число номер 2:");
                    double num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Сумма равна {num1 + num2}");

                    Console.WriteLine("Хотите продолжить работу с калькулятором?\n1 Да \n2 Нет");
                    int exitchoose = int.Parse(Console.ReadLine());
                    if (exitchoose == 1)
                    {
                        goto start;

                    }
                    else
                    {
                        break;
                    }
                case 2:
                    Console.WriteLine("Введите число номер 1:");
                    double min = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число номер 2:");
                    double min1 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Разность равна {min - min1}");

                    Console.WriteLine("Хотите продолжить работу с калькулятором?\n1 Да \n2 Нет");
                    int exitchoose1 = int.Parse(Console.ReadLine());
                    if (exitchoose1 == 1)
                    {
                        goto start;

                    }
                    else
                    {
                        break;
                    }
                case 3:
                    retry:
                    Console.WriteLine("Введите число номер 1:");
                    double del = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число номер 2:");
                    double del1 = double.Parse(Console.ReadLine());
                    if (del1 == 0)
                    {
                        Console.WriteLine("Делить на ноль нельзя, извините!\nПопробовать ещё раз?\n1 Да \n2 Нет");
                        int retry = int.Parse(Console.ReadLine());
                        if (retry == 1)
                        {
                            goto retry;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Результат деления равен {del / del1}");
                    }

                    Console.WriteLine("Хотите продолжить работу с калькулятором?\n1 Да \n2 Нет");
                    int exitchoose2 = int.Parse(Console.ReadLine());
                    if (exitchoose2 == 1)
                    {
                        goto start;

                    }
                    else
                    {
                        break;
                    }
                    case 4:
                    Console.WriteLine("Введите число номер 1:");
                    int mno = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число номер 2:");
                    int mno1 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Результат умножения равен {mno * mno1}");

                    Console.WriteLine("Хотите продолжить работу с калькулятором?\n1 Да \n2 Нет");
                    int exitchoose4 = int.Parse(Console.ReadLine());
                    if (exitchoose4 == 1)
                    {
                        goto start;

                    }
                    else
                    {
                        break;
                    }
                case 5:
                    Console.WriteLine("Введите число:");
                    double chisl = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите процент, который хотите узнать:");
                    double proc = double.Parse(Console.ReadLine());
                    
                    Console.WriteLine($"Процент от числа {chisl} равен {chisl * proc /100}");

                    Console.WriteLine("Хотите продолжить работу с калькулятором?\n1 Да \n2 Нет");
                    int exitchoose3 = int.Parse(Console.ReadLine());
                    if (exitchoose3 == 1)
                    {
                        goto start;

                    }
                    else
                    {
                        break;
                    }
                    case 6:

                    Console.WriteLine("Введите число от которого хотите узнать квадратный корень:");
                    double cor = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Квадратный корень числа равен {Math.Sqrt(cor)}");

                    Console.WriteLine("Хотите продолжить работу с калькулятором?\n1 Да \n2 Нет");
                    int exitchoose5 = int.Parse(Console.ReadLine());
                    if (exitchoose5 == 1)
                    {
                        goto start;

                    }
                    else
                    {
                        break;
                    }
                    case 7:
                    Console.WriteLine("Вы действительно хотите завершить работу с калькулятором?\n1 Да \n2 Нет");
                    int exit = int.Parse(Console.ReadLine());
                    if (exit == 1)
                    {
                        break;

                    }
                    else
                    {
                        goto start;
                    }

                   





            }

        }
    }
}