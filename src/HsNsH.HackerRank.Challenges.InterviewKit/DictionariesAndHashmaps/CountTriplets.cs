namespace InterviewKit.DictionariesAndHashmaps;

public static partial class Result
{
    // Complete the countTriplets function below.
    public static long CountTriplets(List<long> arr, long r)
    {
        return 0;
    }
}

internal static partial class Solution
{
    public static void CountTriplets_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nr = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(nr[0]);

        long r = Convert.ToInt64(nr[1]);

        List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        long ans = Result.CountTriplets(arr, r);

        textWriter.WriteLine(ans);

        textWriter.Flush();
        textWriter.Close();
    }
}