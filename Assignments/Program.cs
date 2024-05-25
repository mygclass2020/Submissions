// 1. Extracting First and Last Names

Console.WriteLine("Enter your full name:");

string full_name = Console.ReadLine();

string[] name = full_name.Split(' ');

Console.WriteLine($"First name: {name[0]}");

Console.WriteLine($"Last name: {name[^1]}");
