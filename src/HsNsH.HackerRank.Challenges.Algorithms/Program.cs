namespace Algorithms;

public static class Program
{
    private static int Main(string[] args)
    {
        try
        {
            var testResultFileFullPath = SetupConsoleApp(args, true);
            if (string.IsNullOrWhiteSpace(testResultFileFullPath)) return 0;

            string[] passArgs;
            if (args.Length > 1)
            {
                passArgs = new string[args.Length - 1];
                Array.Copy(args, 1, passArgs, 0, args.Length - 1);
            }
            else
            {
                passArgs = Array.Empty<string>();
            }

            switch (args[0])
            {
                case "TimeConversation":
                    Warmup.Solution.TimeConversation_Main(passArgs);
                    break;
                case "SimpleArraySum":
                    Warmup.Solution.SimpleArraySum_Main(passArgs);
                    break;
                case "CamelCase":
                    Strings.Solution.CamelCase_Main(passArgs);
                    break;
            }

            ShowChallengeResultsInConsole(testResultFileFullPath);
        }
        catch (Exception) { return -1; }

        return 0;
    }

    private static string SetupConsoleApp(IReadOnlyList<string> args, bool clearOldTestResultsFile = false)
    {
        if (args.Count < 1) return string.Empty;
        if (string.IsNullOrWhiteSpace(args[0])) return string.Empty;
        var selectedChallengeName = args[0];
        var path = Environment.GetEnvironmentVariable("OUTPUT_PATH");
        if (!string.IsNullOrWhiteSpace(path)) return selectedChallengeName;

        var testResultDirPath = $"..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}../TestResults";
        var di = new DirectoryInfo(testResultDirPath);
        if (!Directory.Exists(testResultDirPath))
        {
            di.Create();
            if (!di.Exists) throw new ArgumentException("OUTPUT_PATH error");
        }

        if (clearOldTestResultsFile)
        {
            var oldTestFiles = di.GetFiles();
            foreach (var oldTestFile in oldTestFiles) { oldTestFile.Delete(); }
        }

        var testFileName = $"Challenge_{selectedChallengeName}_{DateTime.UtcNow.Ticks.ToString()}.txt";
        var fi = new FileInfo(Path.Combine(testResultDirPath, testFileName));
        File.AppendAllText(fi.FullName, string.Empty);
        if (!fi.Exists) throw new ArgumentException("OUTPUT_PATH error");
        Environment.SetEnvironmentVariable("OUTPUT_PATH", fi.FullName);

        return fi.FullName;
    }

    private static void ShowChallengeResultsInConsole(string testResultFileFullPath)
    {
        Console.WriteLine("");
        Console.WriteLine("== TEST RESULTS ==");

        var fi = new FileInfo(testResultFileFullPath);
        if (fi.Exists)
        {
            var resultLines = File.ReadLines(testResultFileFullPath).ToList();
            if (resultLines.Count > 0)
            {
                resultLines.ForEach(Console.WriteLine);
            }
        }
        else Console.WriteLine("Challenge results file has not found!");

        Console.WriteLine("== TEST RESULTS ==");
    }
}