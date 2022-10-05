int[] numbers = new int[5];

void FillArray(int[] array, int arr1,int arr2)
{
  for (int i = 0; i<array.Length; i++ )
  {
    array[i] = new Random().Next(arr1,arr2);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i<array.Length; i++ )
{
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int Quantity(int[] array)
{
{
    int count = 0;
    for (int i = 0; i<array.Length; i++)
{
    if (array[i] % 2 == 0)
count++;
 }
  return count;
}
}

FillArray(numbers, 100, 999);
PrintArray(numbers);
Console.WriteLine();

int count = Quantity(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {count}");