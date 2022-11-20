using Core;

namespace InterviewKit;

public static class Program
{
    private static int Main(string[] args)
    {
        try
        {
            var testResultFileFullPath = BaseSetup.SetupConsoleApp(args, typeof(Program).Namespace, true);
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

            var mainMethod = BaseSetup.GetMainMethods(args[0], typeof(Program));
            if (mainMethod == null) return 0;
            mainMethod.Invoke(null, new object[] { passArgs });

            BaseSetup.ShowChallengeResultsInConsole(testResultFileFullPath);
        }
        catch (Exception) { return -1; }

        return 0;
    }
}