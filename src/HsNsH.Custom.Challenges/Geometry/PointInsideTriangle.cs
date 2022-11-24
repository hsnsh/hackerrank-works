namespace HsNsH.Custom.Challenges.Geometry;

public static partial class Result
{
    /* A utility function to calculate area of triangle
 formed by (x1, y1) (x2, y2) and (x3, y3) */
    private static double Area(int x1, int y1, int x2,
        int y2, int x3, int y3)
    {
        return Math.Abs((x1 * (y2 - y3) +
                         x2 * (y3 - y1) +
                         x3 * (y1 - y2)) / 2.0);
    }

    /* A function to check whether point P(x, y) lies
    inside the triangle formed by A(x1, y1),
    B(x2, y2) and C(x3, y3) */
    public static bool PointInsideTriangle(int x1, int y1, int x2,
        int y2, int x3, int y3,
        int x, int y)
    {
        /* Calculate area of triangle ABC */
        double A = Area(x1, y1, x2, y2, x3, y3);

        /* Calculate area of triangle PBC */
        double A1 = Area(x, y, x2, y2, x3, y3);

        /* Calculate area of triangle PAC */
        double A2 = Area(x1, y1, x, y, x3, y3);

        /* Calculate area of triangle PAB */
        double A3 = Area(x1, y1, x2, y2, x, y);

        /* Check if sum of A1, A2 and A3 is same as A */
        return (A == A1 + A2 + A3);
    }
}

internal static partial class Solution
{
    public static void PointInsideTriangle_Main(string[] args)
    {
        /* Let us check whether the point P(10, 15)
lies inside the triangle formed by
A(0, 0), B(20, 0) and C(10, 30) */
        if (Result.PointInsideTriangle(0, 0, 20, 0, 10, 30, 10, 15))
            Console.WriteLine("Inside");
        else
            Console.WriteLine("Not Inside");
    }
}