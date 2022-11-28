namespace Algorithms.Strings;

public static partial class Result
{
    /*
     * Complete the 'palindromeIndex' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int PalindromeIndex(string s)
    {
        if (s.Length < 2) return -1;
        var length = s.Length / 2;
        if (s.Length % 2 != 0) length += 1;
        for (var i = 0; i < length; i++)
        {
            if (s[i] == s[s.Length - 1 - i]) continue;

            if ((s[i + 1] == s[s.Length - 1 - i]) && (s[i] == s[s.Length - 1 - i - 1]))
            {
                if (s[i + 2] == s[s.Length - 2 - i])
                    return i;
                return s.Length - 1 - i;
            }

            if (s[i + 1] == s[s.Length - 1 - i]) return i;

            if (s[i] == s[s.Length - 1 - i - 1]) return s.Length - 1 - i;
        }

        return -1;
    }
}

internal static partial class Solution
{
    public static void PalindromeIndex_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = Result.PalindromeIndex(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}