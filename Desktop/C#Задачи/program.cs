// Задача 4: Задайте массив из 10 случайных чисел из промежутка [-100, 100]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10

// [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2] -> 0

// [10, 11, 12, 13, 14] -> 5

Console.WriteLine("Массив из десяти чисел:");
int[] a=new int[10];
Random random=new Random();
for(int i=0;i<a.Length;i++)
a[i]=random.Next(-100,100);
for(int i=0;i<a.Length;i++)
System.Console.Write($"{a[i],4}");

int count=0;
for(var i=0; i<a.Length;i++)
{
if(i>10 && i<99)
count++;
}
System.Console.WriteLine();
System.Console.WriteLine(count);
