﻿/*
Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Пример:
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
internal class Program
{
    private static void Main(string[] args)
    {
        // Выводим на экран приглашение для ввода натурального числа M
        Console.WriteLine("Введите натуральное число M: ");
        // Считываем введенное пользователем значение и преобразуем его в целое число
        int m = Convert.ToInt32(Console.ReadLine());

        // Выводим на экран приглашение для ввода натурального числа N
        Console.WriteLine("Введите натуральное число N: ");
        // Считываем введенное пользователем значение и преобразуем его в целое число
        int n = Convert.ToInt32(Console.ReadLine());

        // Определяем рекурсивную функцию для вычисления функции Аккермана
        int FunctionAkk(int m, int n)
        {
            // Если m равно 0, возвращаем n + 1
            if (m == 0) return n + 1;
            // Если n равно 0 и m больше 0, рекурсивно вызываем функцию с параметрами m-1 и 1
            else if (n == 0 && m > 0) return FunctionAkk(m - 1, 1);
            // В остальных случаях рекурсивно вызываем функцию дважды
            else return FunctionAkk(m - 1, FunctionAkk(m, n - 1));
        }

        // Вызываем функцию Аккермана с введенными пользователем значениями и выводим результат на экран
        Console.Write($"A(m,n) = {FunctionAkk(m, n)}");
    }
}
