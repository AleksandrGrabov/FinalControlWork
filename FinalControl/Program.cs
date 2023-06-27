Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();
        string[] originalArray = input.Split(',');

        // Шаг 3: Вызов метода FilterArray и вывод результата
        string[] filteredArray = FilterArray(originalArray);
        Console.WriteLine("Обработанный массив:");
        foreach (string item in filteredArray)
        {
            Console.WriteLine(item);
        }

            Console.ReadKey();
    

    static string[] FilterArray(string[] originalArray)
    {
        int count = 0;

        for (int i = 0; i < originalArray.Length; i++)
        {
            if (originalArray[i].Length <= 3)
            {
                count++;
            }
        }

        string[] filteredArray = new string[count];

        count = 0;
        for (int i = 0; i < originalArray.Length; i++)
        {
            if (originalArray[i].Length <= 3)
            {
                filteredArray[count] = originalArray[i];
                count++;
            }
        }

        return filteredArray;
    }