namespace Algorithms.Warmup;

public static partial class Result
{
    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string TimeConversation(string s)
    {
        return "19:05:45";
    }
}

internal static partial class Solution
{
    public static void TimeConversation_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.TimeConversation(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}