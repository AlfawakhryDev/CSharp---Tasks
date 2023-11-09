using System;

public class Program
{
    public const int Npresents = 12; // Define Npresents as a constant

    public static float PresentList(float budget, float bagVolume, int people, float[] presentVolume, float[] presentPrice)
    {
        float maxSpent = 0;

        for (int presentsPerPerson = 1; presentsPerPerson <= Npresents; presentsPerPerson++)
        {
            if (presentsPerPerson * people > Npresents)
            {
                break; // Not enough presents for everyone
            }

            for (int i = 0; i < Npresents; i++)
            {
                float totalSpent = 0;
                float totalVolume = 0;

                for (int j = 0; j < Npresents; j++)
                {
                    int personIndex = j / presentsPerPerson;
                    if (personIndex >= people)
                    {
                        break; // Not enough people to give presents
                    }

                    if (j % presentsPerPerson == 0)
                    {
                        totalSpent += presentPrice[i];
                    }

                    totalVolume += presentVolume[i];

                    if (totalVolume <= bagVolume && totalSpent <= budget && (personIndex == people - 1 || j == Npresents - 1))
                    {
                        maxSpent = Math.Max(maxSpent, totalSpent);
                    }
                }
            }
        }

        return maxSpent;
    }

    public static void Main(string[] args)
    {
        float budget = 183.23f;
        float bagVolume = 64.11f;
        int people = 7;
        float[] presentVolume = new float[Npresents] { 4.53f, 9.11f, 4.53f, 6.00f, 1.04f, 0.87f, 2.57f, 19.45f, 65.59f, 14.14f, 16.66f, 13.53f };
        float[] presentPrice = new float[Npresents] { 12.23f, 45.03f, 12.23f, 32.93f, 6.99f, 0.46f, 7.34f, 65.98f, 152.13f, 7.23f, 10.00f, 25.25f };

        float maxSpent = PresentList(budget, bagVolume, people, presentVolume, presentPrice);
        Console.WriteLine("Maximum amount Nader can spend on presents: " + maxSpent);
    }
}
