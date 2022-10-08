// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] values = new double[2, 2];
double[] points = new double[2];

void InputValues()
{
  for (int i = 0; i < values.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < values.GetLength(1); j++)
    {
    if(j == 0) Console.Write($"Введите значение k{i+1}: ");
      else Console.Write($"Введите значение b{i+1}: ");
      values[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] values)
{
  points[0] = (values[1,1] - values[0,1]) / (values[0,0] - values[1,0]);
  points[1] = points[0] * values[0,0] + values[0,1];
  return points;
}

void OutputResponse(double[,] values)
{
    Decision(values);
    Console.Write($"Точка пересечения прямых: ({points[0]}, {points[1]})");

}

InputValues();
OutputResponse(values);