// ввод числа и вывод суммы цифр в числе.
int num = Convert.ToInt32(Console.ReadLine());//Считали число
int GetCountNumbers(int number)
{
    int count=0;//счетчик
    int sum  = 0;
    
while (number>0)
{    
    sum = sum + number%10;
    number/=10;//number/10=number;
    count++;


}
return sum;
}

Console.WriteLine($"сумма цифр в числе {num} = {GetCountNumbers(num)}");
