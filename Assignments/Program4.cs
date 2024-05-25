// 4: Advanced Text Analyzer

Console.WriteLine("Enter text:");

string input = Console.ReadLine();

int word_count = input.Split(' ').Length;

Console.WriteLine($"Total words: {word_count}");

int avg = input.Replace(" ", "").Count()/word_count;

Console.WriteLine($"Average word length: {avg}");