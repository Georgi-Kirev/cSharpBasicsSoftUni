﻿// Input
int n = int.Parse(Console.ReadLine());

int sum = 0;
int max = int.MinValue;
// Output
for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    sum += number;

    if (number > max)
    {
        max = number;
    }
}

int sumWithoutMax = sum - max;
if (sumWithoutMax == max)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {max}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(max - sumWithoutMax)}");
}