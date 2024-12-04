namespace Stars.Day01;

public class Day01
{
    public static int SumTotalDistance(string filePath)
    {
        var numberList1 = new List<int>();
        var numberList2 = new List<int>();
        
        var textLines = FileIO.LoadTextLinesFromFile(filePath);
        foreach (var textLine in textLines)
        {
            var textSeparator = "   ";
            var numberStrings = textLine.Split(textSeparator);
            
            numberList1.Add(Convert.ToInt32(numberStrings[0]));
            numberList2.Add(Convert.ToInt32(numberStrings[1]));
        }

        numberList1.Sort();
        numberList2.Sort();


        var totalDistance = 0;
        for(var i = 0; i < numberList1.Count; i++)
        {
           var distance = Math.Abs(numberList2[i] - numberList1[i]);
           totalDistance += distance;
        }
        
        return totalDistance;
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