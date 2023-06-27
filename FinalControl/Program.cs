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


string[] FilterArray(string[] originalArray)

int count = 0;
for (int i = 0; i < originalArray.Length; i++)
{
  if (originalArray[i].Length <= 3)
  {
    filteredArray[count] = originalArray[i];
    count++;
  }
}
