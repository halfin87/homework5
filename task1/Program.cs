//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] Randomarray()

{
  int[] array = new int[5];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = Random.Shared.Next(100, 1000);
  }
  return array;
}

int Sumelements(int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (i / 2 == 0)
    {
      sum ++;
    }
  }
  return sum;
}

int[] myArray = Randomarray();
int positivedigit = Sumelements(myArray);
Console.WriteLine($"получившийся массив = [{string.Join(", ", myArray)}]");
Console.WriteLine($"сумма четных чисел = {positivedigit}");