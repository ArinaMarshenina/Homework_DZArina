// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

int GetNumberA()
{
    Console.WriteLine("Введите число A: ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetNumberB()
{

    Console.WriteLine("Введите число B: ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetCycle(int numberone, int numbertwo)
{
    int cycle = 1;
    for(int i=1; i <= numbertwo; i++)
    cycle = cycle * numberone;
    return cycle;
}

int numberone = GetNumberA();
int numbertwo = GetNumberB();
Console.WriteLine($"Число {numberone} в степени {numbertwo} = " + GetCycle(numberone, numbertwo));