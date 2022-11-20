namespace InterviewKit.Warmup;

public static partial class Result
{
    /*
     * Complete the 'jumpingOnClouds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY c as parameter.
     */

    public static int JumpingOnTheClouds(List<int> c)
    {
        int myIndex = 0;
        int countStep = 0;

        while (myIndex < c.Count - 1)
        {
            if (c[myIndex + 1] == 1)
            {
                //jump to 2 steps
                myIndex += 2;
            }
            else
            {
                if (myIndex + 2 <= c.Count - 1 && c[myIndex + 2] == 0)
                {
                    //jump to 2 steps
                    myIndex += 2;
                }
                else
                {
                    //jump to 1 step
                    myIndex += 1;
                }
            }

            countStep++;
        }

        return countStep;
    }
}

internal static partial class Solution
{
    public static void JumpingOnTheClouds_Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

        int result = Result.JumpingOnTheClouds(c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}