Console.WriteLine("Задача : Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. ");
Console.Write("input array size m: ");
int m;

do
{
    m = Convert.ToInt32(Console.ReadLine()); 
    if  (m == 0) Console.WriteLine("Wrong array size");
    else Console.WriteLine("Correct array size! Input array elememts: ");
} while (m == 0);