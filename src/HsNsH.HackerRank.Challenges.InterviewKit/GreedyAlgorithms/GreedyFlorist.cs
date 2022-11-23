namespace InterviewKit.GreedyAlgorithms;

public static partial class Result
{
    // Complete the getMinimumCost function below.
    public static int GetMinimumCost(int k, int[] c)
    {
        var sorted = c.OrderBy(x => x).ToArray();

        var times = 0;
        var previousPurchases = 0;
        var result = 0;

        for (var i = sorted.Length - 1; i >= 0; i--)
        {
            if (times == k)
            {
                previousPurchases++;
                times = 0;
            }

            result += (previousPurchases + 1) * sorted[i];
            times++;
        }

        return result;
    }
}

internal static partial class Solution
{
    public static void GreedyFlorist_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
        int minimumCost = Result.GetMinimumCost(k, c);

        textWriter.WriteLine(minimumCost);

        textWriter.Flush();
        textWriter.Close();
    }
}