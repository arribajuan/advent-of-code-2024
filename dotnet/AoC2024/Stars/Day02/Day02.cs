namespace Stars.Day02;

public class Day02
{
    
    public static int CountSafeReports(string filePath)
    {
        var textLines = FileIO.LoadTextLinesFromFile(filePath);



        return 0;
    }
    
    
    public static string GetFilePath(FileType fileType)
    {
        switch (fileType)
        {
            case FileType.ChallengeData:
                return AppDomain.CurrentDomain.BaseDirectory + "assets/data/day02-data.txt";;
            case FileType.Test:
                return AppDomain.CurrentDomain.BaseDirectory + "assets/data/day02-test.txt";;
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