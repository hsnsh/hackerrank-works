namespace HsNsH.Custom.Challenges.Geometry;

public static partial class Result
{
    public static int NumberOfSquares(int _base)
    {
        // removing the extra part
        // we would always need
        _base = (_base - 2);

        // Since each square has
        // base of length of 2
        _base = _base / 2;

        return _base * (_base + 1) / 2;
    }
}

internal static partial class Solution
{
    public static void SquaresInIsoscelesTriangle_Main(string[] args)
    {
        int _base = 8;
        Console.WriteLine(Result.NumberOfSquares(_base));
    }
}