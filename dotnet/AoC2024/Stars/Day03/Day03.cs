using System.Text.RegularExpressions;

namespace Stars.Day03;

public class Day03
{
    public static int AddMultiplications(string filePath)
    {
        var text = FileIO.LoadTextFromFile(filePath);

        var regex = new Regex(@"mul\((\d{1,3}),(\d{1,3})\)");

        var total = 0;
        foreach (Match match in regex.Matches(text))
        {
            var x = int.Parse(match.Groups[1].Value);
            var y = int.Parse(match.Groups[2].Value);
            total += x * y;
        }

        return total;
    }
    
    
    public static string GetFilePath(FileType fileType)
    {
        switch (fileType)
        {
            case FileType.ChallengeData:
                return AppDomain.CurrentDomain.BaseDirectory + "assets/data/day03-data.txt";;
            case FileType.Test:
                return AppDomain.CurrentDomain.BaseDirectory + "assets/data/day03-test.txt";;
            default:
                return string.Empty;
        }
    }
    
    public enum FileType
    {
        Test,
        ChallengeData
    }
}