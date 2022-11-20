namespace InterviewKit.Arrays;

public static partial class Result
{
    /*
     * Complete the 'hourglassSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int HourglassSum(List<List<int>> arr)
    {
        int maxValue = int.MinValue;
        for (int x = 0; x < 4; x++)
        {
            for (int y = 0; y < 4; y++)
            {
                int hourGlassValue = 0;
                hourGlassValue += arr[x][y];
                hourGlassValue += arr[x][y + 1];
                hourGlassValue += arr[x][y + 2];
                hourGlassValue += arr[x + 1][y + 1];
                hourGlassValue += arr[x + 2][y];
                hourGlassValue += arr[x + 2][y + 1];
                hourGlassValue += arr[x + 2][y + 2];

                if (maxValue < hourGlassValue) maxValue = hourGlassValue;
            }
        }

        return maxValue;
    }
}

internal static partial class Solution
{
    public static void TwoDimensionArray_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.HourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}