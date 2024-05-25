// 3: Text Manipulation Challenge

Console.WriteLine("Enter a line:");

string input = Console.ReadLine();

string trim = input.Trim();

string upper = trim.ToUpper();

Console.WriteLine("");

Console.WriteLine($"New line:");

Console.WriteLine(upper);

Console.WriteLine("");

Console.WriteLine("Enter a the start index of substring:");

int s_index = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");

Console.WriteLine("Enter the length of substring:");

int length = Convert.ToInt32(Console.ReadLine());

string s_string = upper.Substring(s_index, length);

Console.WriteLine("");

Console.WriteLine($"Substring: {s_string}");