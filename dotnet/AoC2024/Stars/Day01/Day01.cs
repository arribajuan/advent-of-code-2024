namespace Stars.Day01;

public class Day01
{
    private static (List<int> list1, List<int> list2) ParseIntegerLists(List<string> input)
    {
        var list1 = new List<int>();
        var list2 = new List<int>();
            
        foreach (var textLine in input)
        {
            var textSeparator = "   ";
            var numberStrings = textLine.Split(textSeparator);
            
            list1.Add(Convert.ToInt32(numberStrings[0]));
            list2.Add(Convert.ToInt32(numberStrings[1]));
        }
        
        return (list1, list2);
    }
    
    public static int SumTotalDistance(string filePath)
    {
        var textLines = FileIO.LoadTextLinesFromFile(filePath);
        var numberLists = ParseIntegerLists(textLines);

        
        numberLists.list1.Sort();
        numberLists.list2.Sort();

        var totalDistance = 0;
        for(var i = 0; i < numberLists.list1.Count; i++)
        {
           totalDistance += Math.Abs(numberLists.list2[i] - numberLists.list1[i]);;
        }
        
        return totalDistance;
    }

    public static int CalculateSimilarityScore(string filePath)
    {
        var textLines = FileIO.LoadTextLinesFromFile(filePath);
        var numberLists = ParseIntegerLists(textLines);


        var similarityScore = 0;

        foreach (var number in numberLists.list1)
        {
            var count = numberLists.list2.FindAll(n => n == number).Count();
            similarityScore += number * count;
        }

        return similarityScore;
    }
    
    public static string GetFilePath(FileType fileType)
    {
        switch (fileType)
        {
            case FileType.ChallengeData:
                return AppDomain.CurrentDomain.BaseDirectory + "assets/data/day01-data.txt";;
            case FileType.Test:
                return AppDomain.CurrentDomain.BaseDirectory + "assets/data/day01-test.txt";;
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