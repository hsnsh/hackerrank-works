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

    // Complete the minimumSwaps function below.
    public static int MinimumSwaps(int[] arr)
    {
        int swapCount = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            while (i + 1 != arr[i])
            {
                int swapIndex = arr[i] - 1;
                int valAtIndex = arr[i];
                int valAtSwapIndex = arr[swapIndex];

                arr[i] = valAtSwapIndex;
                arr[swapIndex] = valAtIndex;
                ++swapCount;
            }
        }

        return swapCount;
    }
}

internal static partial class Solution
{
    public static void MinimumSwaps2_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        int res = Result.MinimumSwaps(arr);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}