// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе

int GetNumber()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetSum(int numberA)
{
int count = Convert.ToString(numberA).Length;
int length = 0;
int sum = 0;

for (int i = 0; i < count; i++){
    length = numberA - numberA % 10;
    sum = sum + (numberA - length);
    numberA = numberA / 10;
}
   return sum;
}
int numberA = GetNumber();
Console.WriteLine($"Сумма цифр в числе {numberA}: " + GetSum(numberA));