// // Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16


System.Console.Write("Введите число A: ");
int numA = int.Parse(Console.ReadLine());

System.Console.Write("Введите число B: ");
int numB = int.Parse(Console.ReadLine());

int Expo (int NumberA, int NumberB)
{
  int result = 1;
  for (int i = 1; i <= NumberB; i++)
  {
    result = result * NumberA;
  }
  return result;
}

System.Console.WriteLine($"A в степени B равно: {Expo(numA, numB)}");


// // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12


System.Console.Write("Введите число: ");
int total = int.Parse(Console.ReadLine());
int Sum (int Number)
{
  int result = 0;
  for (; Number > 0; Number /= 10)
  {
   result = result + Number%10;
  }
  return result;
}

System.Console.WriteLine($"Сумма цифр в числе равна {Sum(total)}");

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] Array = new int[8];

void CreateArray (int [] Numbers)
{
  int length = Numbers.Length;
  
  for (int i = 0; i < length; i++)
  {
      Numbers[i] = new Random().Next(1, 10);
  }
  return;
}


void Print (int[] point)
{
  int value = point.Length;
  for (int count = 0; count < value; count++)
  {
      System.Console.Write(point[count] + " ");
  }
  return;
}

CreateArray(Array);
Print(Array);


