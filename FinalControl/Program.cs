Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();
        string[] originalArray = input.Split(',');

string[] filteredArray = FilterArray(originalArray);
Console.WriteLine("Обработанный массив:"); 
foreach (string item in filteredArray)
{
    Console.WriteLine(item);
}
Console.ReadKey();
