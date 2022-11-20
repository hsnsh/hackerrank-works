namespace InterviewKit.DictionariesAndHashmaps;

public static partial class Result
{
    /*
     * Complete the 'twoStrings' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s1
     *  2. STRING s2
     */

    public static string TwoStrings(string s1, string s2)
    {
        string refStr = "";
        string searchStr = "";

        if (s1.Length > s2.Length)
        {
            refStr = s2;
            searchStr = s1;
        }
        else
        {
            refStr = s1;
            searchStr = s2;
        }

        if (searchStr.Contains(refStr)) return "YES";

        List<char> orderedRef = refStr.OrderBy(x => x).ToList();
        List<char> orderedSearch = searchStr.OrderBy(x => x).ToList();

        int counter = 0;
        while (counter < orderedRef.Count)
        {
            int repeatedCharCount = orderedRef.Count(x => x.Equals(orderedRef[counter]));

            if (orderedSearch.Any(x => x.Equals(orderedRef[counter])))
            {
                return "YES";
            }

            counter += repeatedCharCount;
        }

        return "NO";
    }
}

internal static partial class Solution
{
    public static void TwoStrings_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            string result = Result.TwoStrings(s1, s2);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}