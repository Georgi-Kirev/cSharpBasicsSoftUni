﻿// Input
string city = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());

// Calculations
double commision = 0;

if (city == "Sofia")
{
    if (sales >= 0 && sales <= 500) commision = 0.05;
    else if (sales > 500 && sales <= 1000) commision = 0.07;
    else if (sales > 1000 && sales <= 10000) commision = 0.08;
    else if (sales > 10000) commision = 0.12;
}
else if (city == "Varna")
{
    if (sales >= 0 && sales <= 500) commision = 0.045;
    else if (sales > 500 && sales <= 1000) commision = 0.075;
    else if (sales > 1000 && sales <= 10000) commision = 0.10;
    else if (sales > 10000) commision = 0.13;
}
else if (city == "Plovdiv")
{
    if (sales >= 0 && sales <= 500) commision = 0.055;
    else if (sales > 500 && sales <= 1000) commision = 0.08;
    else if (sales > 1000 && sales <= 10000) commision = 0.12;
    else if (sales > 10000) commision = 0.145;
}

double finalCommisoin = commision * sales;

if (finalCommisoin > 0)
{
    Console.WriteLine($"{finalCommisoin:F2}");
}
else if (city != "Sofia" || city != "Varna" || city != "Plovdiv")
{
    Console.WriteLine("error");
}
else if (finalCommisoin < 0)
{
    Console.WriteLine("error");
}