namespace InterviewKit.GreedyAlgorithms;

public static partial class Result
{
    /*
     * Complete the 'maxMin' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY arr
     */

    public static int MaxMin(int k, List<int> arr)
    {
        var ordered = arr.OrderBy(x => x).ToArray();

        var res = int.MaxValue;
        for (var i = 0; i < ordered.Length - (k - 1); i++)
        {
            int currentMin = ordered[i];
            int currentMax = ordered[i + (k - 1)];

            if (res > currentMax - currentMin) res = currentMax - currentMin;
        }

        return res;
    }
}

internal static partial class Solution
{
    public static void MaxMin_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
            arr.Add(arrItem);
        }

        int result = Result.MaxMin(k, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}