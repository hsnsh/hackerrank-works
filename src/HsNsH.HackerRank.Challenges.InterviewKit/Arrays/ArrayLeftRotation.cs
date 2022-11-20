namespace InterviewKit.Arrays;

public static partial class Result
{
    /*
     * Complete the 'rotLeft' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER d
     */

    public static List<int> RotLeft(List<int> a, int d)
    {
        if (d == a.Count) return a;

        int[] tmpArray = new int[a.Count];

        for (int i = 0; i < a.Count - d; i++)
        {
            tmpArray[i] = a[i + d];
        }

        for (int i = 0; i < d; i++)
        {
            tmpArray[i + (a.Count - d)] = a[i];
        }

        return tmpArray.ToList();
    }
}

internal static partial class Solution
{
    public static void ArrayLeftRotation_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int d = Convert.ToInt32(firstMultipleInput[1]);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> result = Result.RotLeft(a, d);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}