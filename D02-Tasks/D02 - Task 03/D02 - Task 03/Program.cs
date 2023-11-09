namespace D02___Task_03
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 99999999; i++)
            {
                int num = i;
                while (num > 0)
                {
                    if (num % 10 == 1)
                    {
                        count++;
                    }
                    num /= 10;
                }
            }

            Console.WriteLine("Total number of '1's: " + count);
        }
    }

}