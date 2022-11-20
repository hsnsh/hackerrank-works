namespace InterviewKit.Warmup;

public static partial class Result
{
    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int CountingValleys(int steps, string path)
    {
        int currentLevel = 0;
        int valleyCount = 0;

        for (int i = 0; i < path.Length; i++)
        {
            int oldLevel = currentLevel;
            if (path[i] == 'U')
            {
                //up
                currentLevel += 1;
            }
            else
            {
                //down
                currentLevel -= 1;
            }

            if (currentLevel == 0 && oldLevel < 0)
            {
                //climbed valley to sea-level
                valleyCount++;
            }
        }

        return valleyCount;
    }
}

internal static partial class Solution
{
    public static void CountingValleys_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.CountingValleys(steps, path);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}