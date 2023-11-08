namespace D02
{ 

internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write($"Enter value for cell {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int longestDistance = FindLongestEqualCellDistance(array);

        if (longestDistance == -1)
        {
            Console.WriteLine("No equal cells found in the array.");
        }
        else
        {
            Console.WriteLine($"The longest distance between equal cells is: {longestDistance}");
        }
    }

    static int FindLongestEqualCellDistance(int[] array)
    {
        int longestDistance = -1;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    int distance = j - i;
                    if (distance > longestDistance)
                    {
                        longestDistance = distance;
                    }
                }
            }
        }
        return longestDistance;
    }
}
}