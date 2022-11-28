namespace Algorithms.Strings;

public static partial class Result
{
    /*
     * Complete the 'camelcase' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int CamelCase(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return 0;

        var result = 1;

        for (var i = 1; i < s.Length; i++)
        {
            if (Convert.ToInt32(s[i]) >= Convert.ToInt32('A')
                && Convert.ToInt32(s[i]) <= Convert.ToInt32('Z'))
                result++;
        }

        return result;
    }
}

internal static partial class Solution
{
    public static void CamelCase_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = Result.CamelCase(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}