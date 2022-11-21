namespace InterviewKit.GreedyAlgorithms;

public static partial class Result
{
    /*
     * Complete the 'luckBalance' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. 2D_INTEGER_ARRAY contests
     * test
     */

    public static int LuckBalance(int k, List<List<int>> contests)
    {
        var res = 0;
        List<(int cost, int isImportant)> input = contests.Select(x => (x[0], x[1])).ToList();
        var orderedInput = input.OrderByDescending(x => x.isImportant).ThenByDescending(x => x.cost);

        foreach (var current in orderedInput)
        {
            if (k > 0 || current.isImportant == 0)
            {
                res += current.cost;
                k--;
            }
            else if (current.isImportant > 0)
            {
                res -= current.cost;
            }
        }

        return res;
    }
}

internal static partial class Solution
{
    public static void LuckBalance_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> contests = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            contests.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(contestsTemp => Convert.ToInt32(contestsTemp)).ToList());
        }

        int result = Result.LuckBalance(k, contests);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}