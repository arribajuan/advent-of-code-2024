namespace Stars.Day04;

public class Day04
{
    
    public static int CountXMAS(string filePath)
    {
        var letterArray = FileIO.Load2DStringArrayFromFile(filePath);

        var XMASCount = 0;
        for (var i = 0; i < letterArray.GetLength(0); i++)
        {
            for (var j = 0; j < letterArray.GetLength(1); j++)
            {
                if (letterArray[i, j] == "X")
                {
                    XMASCount += IsXMASToTheN(letterArray, i, j) ? 1 : 0;
                    XMASCount += IsXMASToTheNE(letterArray, i, j) ? 1 : 0;
                    XMASCount += IsXMASToTheE(letterArray, i, j) ? 1 : 0;
                    XMASCount += IsXMASToTheSE(letterArray, i, j) ? 1 : 0;
                    XMASCount += IsXMASToTheS(letterArray, i, j) ? 1 : 0;
                    XMASCount += IsXMASToTheSW(letterArray, i, j) ? 1 : 0;
                    XMASCount += IsXMASToTheW(letterArray, i, j) ? 1 : 0;
                    XMASCount += IsXMASToTheNW(letterArray, i, j) ? 1 : 0;
                }
            }
        }

        return XMASCount;
    }

    private static bool IsXMASToTheN(string[,] letterArray, int startX, int startY)
    {
        if (startX - 3 < 0)
        {
            return false;
        }

        if (letterArray[startX, startY] == "X" &&
            letterArray[startX - 1, startY] == "M" &&
            letterArray[startX - 2, startY] == "A" &&
            letterArray[startX - 3, startY] == "S"
           )
        {
            return true;
        }
        
        return false;
    }
    private static bool IsXMASToTheNE(string[,] letterArray, int startX, int startY)
    {
        if (startX == 5 && startY == 0)
        {
            var a = 0;
        }
        
        if (startX - 3 < 0 ||
            startY + 3 >= letterArray.GetLength(1))
        {
            return false;
        }

        if (letterArray[startX, startY] == "X" &&
            letterArray[startX - 1, startY + 1] == "M" &&
            letterArray[startX - 2, startY + 2] == "A" &&
            letterArray[startX - 3, startY + 3] == "S"
           )
        {
            return true;
        }
        
        return false;
    }
    private static bool IsXMASToTheE(string[,] letterArray, int startX, int startY)
    {
        if (startY + 3 >= letterArray.GetLength(1))
        {
            return false;
        }

        if (letterArray[startX, startY] == "X" &&
            letterArray[startX, startY + 1] == "M" &&
            letterArray[startX, startY + 2] == "A" &&
            letterArray[startX, startY + 3] == "S"
           )
        {
            return true;
        }
        
        return false;
    }
    private static bool IsXMASToTheSE(string[,] letterArray, int startX, int startY)
    {
        if (startX + 3 >= letterArray.GetLength(0) ||
            startY + 3 >= letterArray.GetLength(1))
        {
            return false;
        }

        if (letterArray[startX, startY] == "X" &&
            letterArray[startX + 1, startY + 1] == "M" &&
            letterArray[startX + 2, startY + 2] == "A" &&
            letterArray[startX + 3, startY + 3] == "S"
           )
        {
            return true;
        }
        
        return false;
    }
    private static bool IsXMASToTheS(string[,] letterArray, int startX, int startY)
    {
        if (startX + 3 >= letterArray.GetLength(0))
        {
            return false;
        }

        if (letterArray[startX, startY] == "X" &&
            letterArray[startX + 1, startY] == "M" &&
            letterArray[startX + 2, startY] == "A" &&
            letterArray[startX + 3, startY] == "S"
           )
        {
            return true;
        }
        
        return false;
    }
    private static bool IsXMASToTheSW(string[,] letterArray, int startX, int startY)
    {
        if (startX + 3 >= letterArray.GetLength(0) ||
            startY - 3 < 0)
        {
            return false;
        }

        if (letterArray[startX, startY] == "X" &&
            letterArray[startX + 1, startY - 1] == "M" &&
            letterArray[startX + 2, startY - 2] == "A" &&
            letterArray[startX + 3, startY - 3] == "S"
           )
        {
            return true;
        }
        
        return false;
    }
    private static bool IsXMASToTheW(string[,] letterArray, int startX, int startY)
    {
        if (startY - 3 < 0)
        {
            return false;
        }

        if (letterArray[startX, startY] == "X" &&
            letterArray[startX, startY - 1] == "M" &&
            letterArray[startX, startY - 2] == "A" &&
            letterArray[startX, startY - 3] == "S"
           )
        {
            return true;
        }
        
        return false;
    }
    private static bool IsXMASToTheNW(string[,] letterArray, int startX, int startY)
    {
        if (startX - 3 < 0 ||
            startY - 3 < 0)
        {
            return false;
        }

        if (letterArray[startX, startY] == "X" &&
            letterArray[startX - 1, startY - 1] == "M" &&
            letterArray[startX - 2, startY - 2] == "A" &&
            letterArray[startX - 3, startY - 3] == "S"
           )
        {
            return true;
        }
        
        return false;
    }

    
    public static string GetFilePath(FileType fileType)
    {
        switch (fileType)
        {
            case FileType.ChallengeData:
                return AppDomain.CurrentDomain.BaseDirectory + "assets/data/day04-data.txt";;
            case FileType.Test:
                return AppDomain.CurrentDomain.BaseDirectory + "assets/data/day04-test.txt";;
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