internal class Program
{
    private static void Main(string[] args)
    {
        // Задача 1
        Console.WriteLine("Введите номер месяца: ");

        string number = Console.ReadLine();

        switch (number)
        {
            case "12":
            case "1":
            case "2":
                Console.WriteLine("Зима");
                break;
            case "3":
            case "4":
            case "5":
                Console.WriteLine("Весна");
                break;
            case "6":
            case "7":
            case "8":
                Console.WriteLine("Лето");
                break;
            case "9":
            case "10":
            case "11":
                Console.WriteLine("Осень");
                break;

            default:
                Console.WriteLine("Такого месяца не существует");
                break;

        }


        // Задача 2

        Console.WriteLine("Введите номер месяца: ");
        int month = int.Parse(Console.ReadLine());

        if (month <= 2 || month == 12)
        {
            Console.WriteLine("Зима");
        }
        else if (month > 3 && month <= 5)
        {
            Console.WriteLine("Весна");
        }
        else if (month > 5 && month <= 8)
        {
            Console.WriteLine("Лето");
        }
        else if (month > 8 && month <= 11)
        {
            Console.WriteLine("Осень");
        }
        else
        {
            Console.WriteLine("Такого месяца не существует");
        }

        // Задача 3

        Console.WriteLine("Введите число:");
        int num = int.Parse(Console.ReadLine());
        if (num == 0)
        {
            Console.WriteLine("Ваше число является нулём, операция не будет проведена");
        }
        else if (num % 2 == 0)
        {
            Console.WriteLine("Ваше число четное!");
        }
        else
        {
            Console.WriteLine("Ваше число нечетное!");
        }

        // Задача 4

        Console.WriteLine("Введите температуру на улице:");
        int temp = int.Parse(Console.ReadLine());

        if (temp > -5) Console.WriteLine("Тепло");
        if (-5 >= temp && temp > -20) Console.WriteLine("Нормально");
        if (-20 >= temp) Console.WriteLine("Холодно");

        // Задача 5

        Console.WriteLine("Введите номер, чтобы узнать цвет радуги:");
        int color = int.Parse(Console.ReadLine());

        switch (color)
        {
            case 1:
                Console.WriteLine("красный");
                break;
            case 2:
                Console.WriteLine("оранжевый");
                break;
            case 3:
                Console.WriteLine("желтый");
                break;
            case 4:
                Console.WriteLine("зеленый");
                break;
            case 5:
                Console.WriteLine("голубой");
                break;
            case 6:
                Console.WriteLine("синий");
                break;
            case 7:
                Console.WriteLine("фиолетовый");
                break;
            default:
                Console.WriteLine("Неверное значение");
                break;
        }
    }
}