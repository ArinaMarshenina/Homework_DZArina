Console.Write("Введите размеры массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,7));  
}

for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}
 
 Console.WriteLine("Введите местоположение вашего числа по координатам: ");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());

if (a>m && b>n)
 Console.WriteLine("Такого числа в массиве нет");
 else
 { 
 object c = array.GetValue(a,b);
 Console.WriteLine($"Число {c} есть в массиве");
 };