namespace HsNsH.Custom.Challenges.Geometry;

public static partial class Result
{
    // Function to find area
    public static float FindArea(float a, float b, float c)
    {
        // Length of sides must be positive
        // and sum of any two sides
        // must be smaller than third side.
        if (a < 0 || b < 0 || c < 0 || (a + b <= c) || a + c <= b || b + c <= a)
        {
            Console.Write("Not a valid triangle");
            System.Environment.Exit(0);
        }

        float s = (a + b + c) / 2;
        return (float)Math.Sqrt(s * (s - a) *
                                (s - b) * (s - c));
    }
}

internal static partial class Solution
{
    public static void AreaOfTriangle_Main(string[] args)
    {
        float a = 3.0f;
        float b = 4.0f;
        float c = 5.0f;

        Console.Write("Area is " + Result.FindArea(a, b, c));
    }
}