// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

// Console.WriteLine("Введите число M: ");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число N: ");
// int n = int.Parse(Console.ReadLine());
// while(m <= n)
// {
//     Console.Write($"{m} \t");
//     m++;
// }


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число M: ");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число N: ");
// int n = int.Parse(Console.ReadLine());
// int sum = 0;
// while(m <= n)
// {
//     sum = sum + m;
//     Console.Write($"{m} \t");
//     m++;
// }
// Console.WriteLine(sum);




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// A(m,n)
// n+1             m=0
// A(m-1,1)        m>0, n=0
// A(m-1,A(m,n-1)) m>0, n>0

Console.WriteLine("Введите 2 числа: ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int Akkerman (int m , int n)
{
    if (m == 0) return n+1;
    else
    {
        if ((m !=0) && (n == 0)) return Akkerman(m-1,1);
        else return Akkerman(m-1, Akkerman(m,n-1));
    }
}
Console.WriteLine(Akkerman(m,n));