Console.WriteLine("Сколько чисел вы хотите написать: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[m];

void GetNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Counting(int[] numbers)
{
  int count = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
    if(numbers[i] > 0 ) count += 1; 
  }
  return count;
}

GetNumbers(m);

Console.WriteLine($"Чисел больше 0: {Counting(numbers)} ");