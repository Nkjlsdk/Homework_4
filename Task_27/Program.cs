// Ввести массив их восьми элементов, вывести массив
int [] GetMultiArray (int size)
{
int [] arraynum = new int [size];
for (int i = 0; i < 8; i++)
{
    arraynum[i]=Convert.ToInt32(Console.ReadLine());
}

return arraynum;
}
   
    Console.WriteLine ($"Массив: [{String.Join ("; ", GetMultiArray(8))}]");
