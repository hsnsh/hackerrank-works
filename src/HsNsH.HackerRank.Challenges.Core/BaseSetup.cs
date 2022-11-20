using System.Reflection;

namespace Core;

public static class BaseSetup
{
    public static string SetupConsoleApp(IReadOnlyList<string> args, string? domain, bool clearOldTestResultsFile = false)
    {
        if (args.Count < 1) return string.Empty;
        if (string.IsNullOrWhiteSpace(args[0])) return string.Empty;
        var selectedChallengeName = args[0];
        var path = Environment.GetEnvironmentVariable("OUTPUT_PATH");
        if (!string.IsNullOrWhiteSpace(path)) return selectedChallengeName;

        var testResultDirPath = $"..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}../TestResults/{domain ?? string.Empty}";
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

    public static MethodInfo? GetMainMethods(string mainMethodName, Type type)
    {
        var q = from t in type.Assembly.GetTypes()
            where t.IsClass && t.Namespace.StartsWith($"{type.Namespace}.") && t.Name.Equals("Solution")
            select t;

        var mainMethods = new List<MethodInfo>();
        foreach (var t in q.ToList())
        {
            Console.WriteLine($"Namespace: {t.Namespace} , Name: {t.Name}");
            mainMethods.AddRange(t.GetMethods(BindingFlags.Static | BindingFlags.Public));
        }

        return mainMethods.FirstOrDefault(x => x.Name.Equals($"{mainMethodName}_Main"));
    }

    public static void ShowChallengeResultsInConsole(string testResultFileFullPath)
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
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Challenge results file has not found!");
            Console.WriteLine("");
        }

        Console.WriteLine("== TEST RESULTS ==");
    }
}