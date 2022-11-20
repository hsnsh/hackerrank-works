namespace InterviewKit.DictionariesAndHashmaps;

public static partial class Result
{
    /*
     * Complete the 'checkMagazine' function below.
     *
     * The function accepts following parameters:
     *  1. STRING_ARRAY magazine
     *  2. STRING_ARRAY note
     */

    public static void CheckMagazine(List<string> magazine, List<string> note)
    {
        List<string> orderedNote = note.OrderBy(x => x).ToList();
        List<string> orderedMagazine = magazine.OrderBy(x => x).ToList();

        if (orderedNote.Count > orderedMagazine.Count)
        {
            Console.WriteLine("No");
            return;
        }

        if (orderedNote.Count == orderedMagazine.Count)
        {
            for (int i = 0; i < orderedNote.Count; i++)
            {
                if (!orderedNote[i].Equals(orderedMagazine[i]))
                {
                    Console.WriteLine("No");
                    return;
                }
            }
        }
        else
        {
            int index = 0;
            while (index < orderedNote.Count)
            {
                bool hasNotFound = false;
                int wordCount = orderedNote.Count(x => x.Equals(orderedNote[index]));
                if (wordCount == 1)
                {
                    if (!orderedMagazine.Any(x => x.Equals(orderedNote[index])))
                    {
                        hasNotFound = true;
                    }
                }
                else
                {
                    int magazineFoundTotal = orderedMagazine.Count(x => x.Equals(orderedNote[index]));

                    if (!(magazineFoundTotal >= wordCount))
                    {
                        hasNotFound = true;
                    }
                }

                if (hasNotFound)
                {
                    Console.WriteLine("No");
                    return;
                }

                index += wordCount;
            }
        }


        Console.WriteLine("Yes");
    }
}

internal static partial class Solution
{
    public static void HashTablesRansomNote_Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(firstMultipleInput[0]);

        int n = Convert.ToInt32(firstMultipleInput[1]);

        List<string> magazine = Console.ReadLine().TrimEnd().Split(' ').ToList();

        List<string> note = Console.ReadLine().TrimEnd().Split(' ').ToList();

        Result.CheckMagazine(magazine, note);
    }
}