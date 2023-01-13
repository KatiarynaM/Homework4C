// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A
// в натуральную степень B.  { 3, 5 -> 243 (3⁵)/ 2, 4 -> 16}
Console.WriteLine($"Введите число:  ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"В какую степень его возвести?");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {A} в степени {B} равно {GetDegree(A, B)}");


//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// {452 -> 11 / 82 -> 10 / 9012 -> 12)

Console.WriteLine($"Введите число:  ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа {x} равна {GetSumDigits(x)}");

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] NewArray = GetArray(8);
Console.WriteLine($"[{string.Join("  , ", NewArray)}]");
            
//------------methods---
int[] GetArray(int size){
      int[] Array = new int[size];
      for (int i = 0; i < size; i++){
            Array[i] = new Random().Next(1, 14);
            }
      return Array;
}

int GetDegree(int num, int degree){
      int result = 1;
      for (int i = 1; i <= degree; i++){
            result = result * num;
            }
      return result;
}

int GetSumDigits(int num){
      string Num = Convert.ToString(num);
      int a = Num.Length;
      int result = 0;
      for (int i = 0; i < a; i++){
      result = result + Num[i]-48;// не знаю, но почему-то без " -48" работает не верно!!! 
      }     
 return result;
}
