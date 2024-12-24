namespace Stars.Day04;

public class Day4Test
{
    [Fact]
    public void Test_Day04_CountXMAS_FromTestFile_Star1()
    {
        var XMASCount = Day04.CountXMAS(Day04.GetFilePath(Day04.FileType.Test));
        
        Assert.Equal(18, XMASCount);
    }
    
    [Fact]
    public void Test_Day04_CountXMAS_FromDataFile_Star1()
    {
        var XMASCount = Day04.CountXMAS(Day04.GetFilePath(Day04.FileType.ChallengeData));
        
        Assert.Equal(2507, XMASCount);
    }
    
    [Fact]
    public void Test_Day04_CountX_MAS_FromTestFile_Star2()
    {
        var X_MASCount = Day04.CountX_MAS(Day04.GetFilePath(Day04.FileType.Test));
        
        Assert.Equal(9, X_MASCount);
    }
    
    [Fact]
    public void Test_Day04_CountX_MAS_FromDataFile_Star2()
    {
        var X_MASCount = Day04.CountX_MAS(Day04.GetFilePath(Day04.FileType.ChallengeData));
        
        Assert.Equal(1969, X_MASCount);
    }
}