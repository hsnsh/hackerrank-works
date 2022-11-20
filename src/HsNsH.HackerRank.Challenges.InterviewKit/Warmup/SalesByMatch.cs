namespace InterviewKit.Warmup;

public static partial class Result
{
    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int SockMerchant(int n, List<int> ar)
    {
        int result = 0;
        List<int> dLsit = ar.Distinct().ToList();

        for (int i = 0; i < dLsit.Count; i++)
        {
            int countSocks = ar.Count(x => x == dLsit[i]);

            if (countSocks % 2 != 0) countSocks = countSocks - 1;

            result += countSocks / 2;
        }

        return result;
    }
}

internal static partial class Solution
{
    public static void SalesByMatch_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.SockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}