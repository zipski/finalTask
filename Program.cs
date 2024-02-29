using System;

class Program
{
    static void Main()
    {
        // задаем массив строк с названиями брендов
        string[] carBrands = { "BMW", "Audi", "VW", 'VAZ', "Ford", "Fiat", "GM", "Kia", 'LUAZ'};

        // создаем новый массив для хранения результатов
        string[] result = new string[carBrands.Length];
        int realSize = 0;

        // ищем в массиве по длине
        foreach (var brand in carBrands)
        {
            if (brand.Length <= 3)
            {
                result[realSize++] = brand; // добавляем марки в новый массив        
            }
        }

        // Вывод берндов автомобилей
        Console.WriteLine("Бренды автомобилей с названиями до 3 символов:");
        for (int i = 0; i < realSize; i++)
        {
            Console
        }
    }
}
