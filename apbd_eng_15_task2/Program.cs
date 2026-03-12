Console.WriteLine("Enter numbers separated by space:");
string input = Console.ReadLine();
int[] numbers = input.Split(' ').Select(int.Parse).ToArray();