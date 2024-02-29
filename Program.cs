using System;

class Program
{
    static void Main()
    {
        // задаем массив строк с названиями брендов
        string[] carBrands = { "BMW", "Audi", "VW", "Ferrari",};

        // создаем новый массив для хранения результатов
        string[] result = new string[carBrands.Length];
        int position = 0;

        // ищем в массиве по длине
        foreach (var brand in carBrands)
        {
            if (brand.Length <= 3)
            {
                result[position++] = brand; // добавляем марки в новый массив        
            }
        }

        // Вывод берндов автомобилей
        Console.WriteLine("Бренды автомобилей с названиями до 3 символов:");
        for (int i = 0; i < position; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}
