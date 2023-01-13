/*Задача 4: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

System.Console.WriteLine("Введите число >");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

if (number <= 1)
{
    System.Console.WriteLine("Нет чётных чисел для заданного условия");
}

{
    while (count <= number)
    {
        if (count % 2 == 0 && count > 0)
        {
            System.Console.Write($"{count} ");
        }
        count++;
    }
}