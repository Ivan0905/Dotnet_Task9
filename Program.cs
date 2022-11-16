// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// Console.WriteLine("Введите число N");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{Func(N)}");

// string Func(int n)
// {
//     if (n == 1)
//         return "1";
//     else
//         return n + ", " + Func(n - 1);
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число M");
// int M = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число N ,больше числа M");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(Func2(M, N));
// int Func2(int m, int n)
// {
//     if (m == n)
//     {
//         return m;
//     }
//     else if ((n-m)==1){
//         return n+m;
//     }
//     else
//     {
//         return m + n + Func2(m + 1, n - 1);
//     }
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29
Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Функция Аккермана A({M},{N}) = {AckFunc(M, N)}");

int AckFunc(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckFunc(m - 1, 1);
    if (m > 0 && n > 0) return AckFunc(m - 1, AckFunc(m, n - 1));
    return AckFunc(m, n);
}
