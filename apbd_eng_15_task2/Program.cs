Console.WriteLine("Enter numbers separated by space:");
string input = Console.ReadLine();
int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

if (numbers.Length == 0)
{
    Console.WriteLine("Error: No numbers provided.");
    return;
}

Console.WriteLine("another commit");