namespace D02
{


internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        Array.Reverse(words);

        string reversedString = string.Join(" ", words);

        Console.WriteLine("Output: " + reversedString);
    }
}
}

