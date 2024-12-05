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
    
    [Fact]
    public void Test_Day03_AddMulsWithConditionals_FromTestFile_Star2()
    {
        var mulTotal = Day03.AddMultiplicationsWithConditionals(Day03.GetFilePath(Day03.FileType.Test2));
        
        Assert.Equal(48, mulTotal);
    }
    
    [Fact]
    public void Test_Day03_AddMulsWithConditionals_FromDataFile_Star2()
    {
        var mulTotal = Day03.AddMultiplicationsWithConditionals(Day03.GetFilePath(Day03.FileType.ChallengeData));
        
        Assert.Equal(67269798, mulTotal);
    }
}