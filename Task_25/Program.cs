// ввод двух чисел (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A:");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B:");
int B = Convert.ToInt32(Console.ReadLine());

int result = Convert.ToInt32(Math.Pow(A,B));

Console.WriteLine($"{A}, {B}  {result}");
