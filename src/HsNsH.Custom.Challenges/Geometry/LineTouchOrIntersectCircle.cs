namespace HsNsH.Custom.Challenges.Geometry;

public static partial class Result
{
    public static void CheckCollision(int a, int b, int c,
        int x, int y, int radius)
    {
        // Finding the distance of line from center.
        double dist = (Math.Abs(a * x + b * y + c)) /
                      Math.Sqrt(a * a + b * b);

        // Checking if the distance is less than,
        // greater than or equal to radius.
        if (radius == (int)dist)
            Console.WriteLine("Touch");
        else if (radius > dist)
            Console.WriteLine("Intersect");
        else
            Console.WriteLine("Outside");
    }
}

internal static partial class Solution
{
    public static void LineTouchOrIntersectCircle_Main(string[] args)
    {
        int radius = 5;
        int x = 0, y = 0;
        int a = 3, b = 4, c = 25;

        Result.CheckCollision(a, b, c, x, y, radius);
    }
}