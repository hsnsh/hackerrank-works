namespace Algorithms.Strings;

public static partial class Result
{
    /*
     * Complete the 'anagram' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int Anagram(string s)
    {
        if (s.Length % 2 != 0) return -1;

        var alphabet = new int[26];
        for (var i = 0; i < s.Length; i++)
        {
            alphabet[Convert.ToInt32(s[i]) - Convert.ToInt32('a')] += i < s.Length / 2 ? 1 : -1;
        }

        return alphabet.Where(x => x > 0).Sum();
    }
}

internal static partial class Solution
{
    public static void Anagram_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = Result.Anagram(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}