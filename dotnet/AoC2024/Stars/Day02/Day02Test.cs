namespace Stars.Day02;

public class Day02Test
{
    [Fact]
    public void Test_Day02_CountSafeReports_FromTestFile_Star1()
    {
        var safeReports = Day02.CountSafeReports(Day02.GetFilePath(Day02.FileType.Test));
        
        Assert.Equal(2, safeReports);
    }
    
    [Fact]
    public void Test_Day02_CountSafeReports_FromDataFile_Star1()
    {
        var safeReports = Day02.CountSafeReports(Day02.GetFilePath(Day02.FileType.ChallengeData));
        
        Assert.Equal(224, safeReports);
    }
    
    [Fact]
    public void Test_Day02_CountSafeAndDampenedReports_FromTestFile_Star2()
    {
        var safeReports = Day02.CountSafeAndDampenedReports(Day02.GetFilePath(Day02.FileType.Test));
        
        Assert.Equal(4, safeReports);
    }
    
    [Fact]
    public void Test_Day02_CountSafeAndDampenedReports_FromDataFile_Star2()
    {
        var safeReports = Day02.CountSafeAndDampenedReports(Day02.GetFilePath(Day02.FileType.ChallengeData));
        
        Assert.Equal(293, safeReports);
    }
}