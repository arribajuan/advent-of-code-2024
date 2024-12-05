namespace Stars.Day02;

public class Day02
{
    public static int CountSafeReports(string filePath)
    {
        var textLines = FileIO.LoadTextLinesFromFile(filePath);
        var reports = ParseReports(textLines);

        return reports.Count(x => x.IsSafe == true);
    }
    
    public static int CountSafeAndDampenedReports(string filePath)
    {
        var textLines = FileIO.LoadTextLinesFromFile(filePath);
        var reports = ParseReports(textLines);

        var safeReportCount = reports.Count(x => x.IsSafe == true);

        var dampenedSafeReportCount = 0;
        foreach (var report in reports.Where(x => x.IsSafe == false))
        {
            if (CountDampenedReports(report) > 0)
            {
                dampenedSafeReportCount++;
            }
        }
        
        return safeReportCount + dampenedSafeReportCount;
    }
    
    private static int CountDampenedReports(Report report)
    {
        var textLines = new List<string>();
        
        for (var i = 0; i < report.Levels.Count; i++)
        {
            var textLine = String.Empty;
            
            for (var j = 0; j < report.Levels.Count; j++)
            {
                if (i != j)
                {
                    textLine += report.Levels[j] + " ";
                }
            }
            
            textLines.Add(textLine.Trim());
        }
        
        var reports = ParseReports(textLines);

        return reports.Count(x => x.IsSafe == true);
    }
    
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