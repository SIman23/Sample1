using System;
class Program
{
    static void Main()
    {
        // Ввод массива строк с клавиатуры
        Console.WriteLine("Введите строки через пробел:");
        string input = Console.ReadLine();
        
        // Разделение введенной строки на массив строк
        string[] inputStrings = input.Split(' ');

        // Создание нового массива для строк длиной <= 3 символов
        string[] resultStrings = FilterShortStrings(inputStrings);

        // Вывод результата
        Console.WriteLine("Строки длиной <= 3 символа:");
        foreach (string str in resultStrings)
        {
            if (str != null) // Печатаем только ненулевые элементы
            {
                Console.WriteLine(str);
            }
        }
    }
}
