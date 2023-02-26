// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int getNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int arraySum(int m, int n)
{
    if (n < m)
    {
        int temp = 0;
        temp = m;
        m = n;
        n = temp;
    }
    if (n == m)
    {
        return n;
    }    
    return n + arraySum(m, n-1);
}

int m = getNumber("Введите число M");
int n = getNumber("Введите число N");
int result = arraySum(m, n);
System.Console.WriteLine(result);