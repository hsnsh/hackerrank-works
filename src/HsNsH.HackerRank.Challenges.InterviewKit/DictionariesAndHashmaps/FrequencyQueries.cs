namespace InterviewKit.DictionariesAndHashmaps;

public static partial class Result
{
    // Complete the freqQuery function below.
    public static List<int> FreqQuery(List<List<int>> queries)
    {
        return new List<int>();
    }
}

internal static partial class Solution
{
    public static void FrequencyQueries_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < q; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        List<int> ans = Result.FreqQuery(queries);

        textWriter.WriteLine(String.Join("\n", ans));

        textWriter.Flush();
        textWriter.Close();
    }
}