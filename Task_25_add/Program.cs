// цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A:");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B:");
int B = Convert.ToInt32(Console.ReadLine());

int increase = 1;

for (int i = 0; i < B; i++)
{
    increase *= A;
}

Console.WriteLine($"{A}, {B}  {increase}");
