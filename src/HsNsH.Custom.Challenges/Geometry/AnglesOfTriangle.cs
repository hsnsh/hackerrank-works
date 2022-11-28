namespace HsNsH.Custom.Challenges.Geometry;

public static partial class Result
{
    // returns square of distance b/w two points
    private static int LengthSquare(Point p1, Point p2)
    {
        int xDiff = p1.x - p2.x;
        int yDiff = p1.y - p2.y;
        return xDiff * xDiff + yDiff * yDiff;
    }

    public static void PrintAngle(Point A, Point B, Point C)
    {
        // Square of lengths be a2, b2, c2
        int a2 = LengthSquare(B, C);
        int b2 = LengthSquare(A, C);
        int c2 = LengthSquare(A, B);

        // length of sides be a, b, c
        float a = (float)Math.Sqrt(a2);
        float b = (float)Math.Sqrt(b2);
        float c = (float)Math.Sqrt(c2);

        // From Cosine law
        float alpha = (float)Math.Acos((b2 + c2 - a2) /
                                       (2 * b * c));
        float betta = (float)Math.Acos((a2 + c2 - b2) /
                                       (2 * a * c));
        float gamma = (float)Math.Acos((a2 + b2 - c2) /
                                       (2 * a * b));

        // Converting to degree
        alpha = (float)(alpha * 180 / Math.PI);
        betta = (float)(betta * 180 / Math.PI);
        gamma = (float)(gamma * 180 / Math.PI);

        // printing all the angles
        Console.WriteLine("alpha : " + alpha);
        Console.WriteLine("betta : " + betta);
        Console.WriteLine("gamma : " + gamma);
    }
}

internal static partial class Solution
{
    public static void AnglesOfTriangle_Main(string[] args)
    {
        Point A = new Point(0, 0);
        Point B = new Point(0, 1);
        Point C = new Point(1, 0);

        Result.PrintAngle(A, B, C);
    }
}