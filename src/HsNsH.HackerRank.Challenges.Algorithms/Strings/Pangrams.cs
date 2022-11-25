namespace Algorithms.Strings;

public static partial class Result
{
    /*
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string Pangrams(string s)
    {
        var alphabet = new int[26];
        var words = s.Split(" ");

        foreach (var word in words)
        {
            var lowerCharValues = word.ToLower().Select(t => Convert.ToInt32(t) - Convert.ToInt32('a'));
            foreach (var charIndex in lowerCharValues)
            {
                alphabet[charIndex]++;
            }
        }

        return alphabet.All(x => x > 0) ? "pangram" : "not pangram";
    }
}

internal static partial class Solution
{
    public static void Pangrams_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.Pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}