namespace HsNsH.Custom.Challenges.Strings;

public static partial class Result
{
    private const int NoOfChars = 256;

    private static bool AreAnagram(string str1, string str2)
    {
        if (str1.Length != str2.Length)
            return false;

        var usedCharCountArray = new int[NoOfChars];

        for (var i = 0; i < str1.Length && i < str2.Length; i++)
        {
            usedCharCountArray[str1[i]]++;
            usedCharCountArray[str2[i]]--;
        }

        return usedCharCountArray.All(x => x == 0);
    }

    // This function prints all anagram pairs in a
    // given array of strings
    public static string[] FindAllAnagrams(string[] arr, int n)
    {
        var result = new List<string>();
        for (var i = 0; i < n; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                if (AreAnagram(arr[i], arr[j]))
                {
                    result.Add(arr[i] + " is anagram of " + arr[j]);
                }
            }
        }

        return result.ToArray();
    }
}

internal static partial class Solution
{
    public static void FindAllAnagrams_Main(string[] args)
    {
        string[] arr = { "geeksquiz", "geeksforgeeks", "abcd", "forgeeksgeeks", "zuiqkeegs" };
        var n = arr.Length;
        var results = Result.FindAllAnagrams(arr, n);

        foreach (var result in results) { Console.WriteLine(result); }
    }
}