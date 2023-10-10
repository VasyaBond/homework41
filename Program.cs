using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите числа через запятую:");
        string input = Console.ReadLine();

        // Разделяем введенные числа по запятой и помещаем их в массив строк
        string[] numbers = input.Split(',');

        int count = 0; // Инициализируем счетчик чисел больше нуля

        foreach (string number in numbers)
        {
            // Преобразуем строку в число (целое или вещественное)
            if (double.TryParse(number.Trim(), out double num))
            {
                // Проверяем, больше ли число нуля
                if (num > 0)
                {
                    count++; // Увеличиваем счетчик, если число больше нуля
                }
            }
        }

        Console.WriteLine($"Число чисел больше нуля: {count}");
    }
}
