﻿// Input
double speed = double.Parse(Console.ReadLine());

// Calculation

if (speed <= 10) Console.WriteLine("slow");
else if (speed > 10 && speed <= 50) Console.WriteLine("average");
else if (speed > 50 && speed <= 150) Console.WriteLine("fast");
else if (speed > 150 && speed <= 1000) Console.WriteLine("ultra fast");
else Console.WriteLine("extremely fast");