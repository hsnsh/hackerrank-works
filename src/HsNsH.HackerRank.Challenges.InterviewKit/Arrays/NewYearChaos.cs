namespace InterviewKit.Arrays;

public static partial class Result
{
    /*
     * Complete the 'minimumBribes' function below.
     *
     * The function accepts INTEGER_ARRAY q as parameter.
     */

    public static void MinimumBribes(List<int> q)
    {
        int totalBribes = 0;
        int p1 = 1;
        int p2 = 2;
        int p3 = 3;

        for (int i = 0; i < q.Count; i++)
        {
            if (q[i] == p1)
            {
                p1 = p2;
                p2 = p3;
                ++p3;
            }
            else if (q[i] == p2)
            {
                ++totalBribes;
                p2 = p3;
                ++p3;
            }
            else if (q[i] == p3)
            {
                totalBribes += 2;
                ++p3;
            }
            else
            {
                Console.WriteLine("Too chaotic");
                return;
            }
        }

        Console.WriteLine(totalBribes);
    }
}

internal static partial class Solution
{
    public static void NewYearChaos_Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

            Result.MinimumBribes(q);
        }
    }
}