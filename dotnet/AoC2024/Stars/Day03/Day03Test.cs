namespace Stars.Day03;

public class Day03Test
{
    [Fact]
    public void Test_Day03_AddMuls_FromTestFile_Star1()
    {
        var mulTotal = Day03.AddMultiplications(Day03.GetFilePath(Day03.FileType.Test));
        
        Assert.Equal(161, mulTotal);
    }
    
    [Fact]
    public void Test_Day03_AddMuls_FromDataFile_Star1()
    {
        var mulTotal = Day03.AddMultiplications(Day03.GetFilePath(Day03.FileType.ChallengeData));
        
        Assert.Equal(188741603, mulTotal);
    }
}