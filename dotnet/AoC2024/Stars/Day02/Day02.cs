namespace Stars.Day02;

public class Day02
{
    private static List<Report> ParseReports(List<string> reportLines)
    {
        var reports = new List<Report>();
        
        foreach (var reportLine in reportLines)
        {
            var newReport = new Report();
            newReport.Levels = new List<int>();
            
            foreach (var level in reportLine.Split(" "))
            {
                newReport.Levels.Add(Convert.ToInt32(level));
            }
            
            reports.Add(newReport);
        }

        return reports;
    }
    public static int CountSafeReports(string filePath)
    {
        var textLines = FileIO.LoadTextLinesFromFile(filePath);
        var reports = ParseReports(textLines);

        return reports.Count(x => x.IsSafe == true);
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