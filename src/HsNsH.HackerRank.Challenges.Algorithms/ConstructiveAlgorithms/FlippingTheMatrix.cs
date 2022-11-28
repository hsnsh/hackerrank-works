using System.ComponentModel.DataAnnotations.Schema;

namespace Algorithms.ConstructiveAlgorithms;

public static partial class Result
{
    /*
     * Complete the 'flippingMatrix' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY matrix as parameter.
     */

    public static int FlippingMatrix(List<List<int>> matrix)
    {
        int result = 0;
        int n = matrix.Count;
        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                int top_left = matrix[i][j];
                int top_right = matrix[i][n - 1 - j];
                int bottom_left = matrix[n - 1 - i][j];
                int bottom_right = matrix[n - 1 - i][n - 1 - j];

                result += Math.Max(Math.Max(top_left, top_right), Math.Max(bottom_left, bottom_right));
            }
        }

        return result;
    }
}

internal static partial class Solution
{
    public static void FlippingTheMatrix_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> matrix = new List<List<int>>();

            for (int i = 0; i < 2 * n; i++)
            {
                matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
            }

            int result = Result.FlippingMatrix(matrix);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}