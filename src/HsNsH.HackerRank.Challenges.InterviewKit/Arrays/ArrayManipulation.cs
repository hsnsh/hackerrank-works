namespace InterviewKit.Arrays;

public static partial class Result
{
    /*
     * Complete the 'arrayManipulation' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static long ArrayManipulation(int n, List<List<int>> queries)
    {
        long[] mArray = new long[n];
        long maxValue = long.MinValue;
        for (int i = 0; i < queries.Count; i++)
        {
            int start = queries[i][0] - 1;
            int end = queries[i][1] - 1;
            int plus = queries[i][2];

            mArray[start] += plus;
            if (end + 1 < n)
            {
                mArray[end + 1] -= plus;
            }
        }

        for (int i = 1; i < n; i++)
        {
            mArray[i] += mArray[i - 1];
            maxValue = Math.Max(maxValue, mArray[i]);
        }

        return maxValue;
    }
}

internal static partial class Solution
{
    public static void ArrayManipulation_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < m; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        long result = Result.ArrayManipulation(n, queries);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}