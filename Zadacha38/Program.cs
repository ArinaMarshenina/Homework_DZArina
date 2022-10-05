double[] numbers = new double[5];

  for (int i = 0; i < numbers.Length; i++ )
  {
    numbers[i] = new Random().Next(1, 10);
    Console.Write(numbers[i] + " ");
  }

double max = numbers[0];
double min = numbers[0];

  for (int i = 1; i < numbers.Length; i++)
  {
    if (max < numbers[i])
    {
      max = numbers[i];
    }
        if (min > numbers[i])
    {
      min = numbers[i];
    }
  }

double diff = max - min;
Console.WriteLine();

  Console.WriteLine($"Разница между между максимальным {max} и минимальным {min} элементов массива: {diff}");