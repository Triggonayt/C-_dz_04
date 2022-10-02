


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Clear();
// Console.WriteLine("Enter number A");
// Console.WriteLine("Enter number B");
// int A = Convert.ToInt32(Console.ReadLine());
// int B = Convert.ToInt32(Console.ReadLine());
// int st = A;
// for(int i = 1; i < B; i++)
// {
//    st = st * A;
// }
// Console.WriteLine(st);





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.Clear();
// Console.WriteLine("Enter number");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while ( n > 0)
// {
//     int b = n % 10;
//     n = n / 10;
//     sum = sum + b;
// }
// Console.WriteLine(sum);



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



Console.Clear();
int [] array = new int[8];
int i  = 0;
while (i < array.Length)
{
    array[i] = new Random().Next(0,10);
    i++;
}
Console.WriteLine(String.Join(" ",array));