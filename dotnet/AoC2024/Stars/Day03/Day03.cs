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

    public static int AddMultiplicationsWithConditionals(string filePath)
    {
        var text = FileIO.LoadTextFromFile(filePath);

        var regexMultiplication = new Regex(@"mul\((\d{1,3}),(\d{1,3})\)");
        var regexDo = new Regex(@"do\(\)");
        var regexDont = new Regex(@"don't\(\)");

        var instructions = new List<Instruction>();
        foreach (Match match in regexMultiplication.Matches(text))
        {
            instructions.Add(new Instruction
            {
                Type = Type.Multiplication,
                X = int.Parse(match.Groups[1].Value),
                Y = int.Parse(match.Groups[2].Value),
                Index = match.Index
            });
        }
        
        foreach (Match match in regexDo.Matches(text))
        {
            instructions.Add(new Instruction
            {
                Type = Type.Do,
                Index = match.Index
            });
        }

        foreach (Match match in regexDont.Matches(text))
        {
            instructions.Add(new Instruction
            {
                Type = Type.Dont,
                Index = match.Index
            });
        }
        
        var sortedInstructions = instructions.OrderBy(x => x.Index).ToList();

        var total = 0;
        var isMulEnabled = true;
        foreach (var instruction in sortedInstructions)
        {
            switch (instruction.Type)
            {
                case Type.Do:
                    isMulEnabled = true;
                    break;
                case Type.Dont:
                    isMulEnabled = false;
                    break;
                case Type.Multiplication:
                    if (isMulEnabled)
                    {
                        total += instruction.X * instruction.Y;
                    }
                    break;
            }
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
            case FileType.Test2:
                return AppDomain.CurrentDomain.BaseDirectory + "assets/data/day03-test2.txt";;
            default:
                return string.Empty;
        }
    }
    
    public enum FileType
    {
        Test,
        Test2,
        ChallengeData
    }
}