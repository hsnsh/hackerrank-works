namespace InterviewKit.Warmup;

public static partial class Result
{
    /*
     * Complete the 'repeatedString' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. LONG_INTEGER n
     */

    public static long RepeatedString(string s, long n)
    {
        int halfWordLength = (int)(n % s.Length);
        long repeatedWordCount = (n - halfWordLength) / s.Length;

        long repeatedLetterInFullWord = s.LongCount(x => x == 'a');
        long repeatedLetterInHalfWord = s.Substring(0, halfWordLength).LongCount(x => x == 'a');

        return (repeatedWordCount * repeatedLetterInFullWord) + repeatedLetterInHalfWord;
    }
}

internal static partial class Solution
{
    public static void RepeatedString_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.RepeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}