﻿// Input
string name = Console.ReadLine();
string pass = Console.ReadLine();

string input = Console.ReadLine();
while (input != pass)
{
    input = Console.ReadLine();
}

Console.WriteLine($"Welcome {name}!");