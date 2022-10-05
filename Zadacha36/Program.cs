
int[] numbers = new int[4];
int RandomNumbers(int [] array, int arr1, int arr2)
  {
    int sumElements = 0;
    for (int i = 0; i <array.Length; i++ ){
    array[i] = new Random().Next(arr1,arr2);

    Console.Write(array[i] + " ");
      if (i % 2 != 0)
      {
        sumElements = sumElements + array[i];
      }
    }
  return sumElements;
  }

int count = RandomNumbers(numbers, 1, 4);
Console.WriteLine();

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {count}");