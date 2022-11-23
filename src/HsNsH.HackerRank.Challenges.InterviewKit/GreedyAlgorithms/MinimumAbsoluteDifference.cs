namespace InterviewKit.GreedyAlgorithms;

public static partial class Result
{
    /*
     * Complete the 'minimumAbsoluteDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int MinimumAbsoluteDifference(List<int> arr)
    {
        var ordered = arr.OrderBy(x => x).ToArray();

        var result = int.MaxValue;
        for (var i = 0; i < ordered.Length - 1; i++)
        {
            int diff = Math.Abs(ordered[i] - ordered[i + 1]);
            if (result > diff) result = diff;
        }

        return result;
    }
}

internal static partial class Solution
{
    public static void MinimumAbsoluteDifference_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.MinimumAbsoluteDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}