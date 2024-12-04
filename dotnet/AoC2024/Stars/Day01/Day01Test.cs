namespace Stars.Day01;

public class Day01Test
{
    [Fact]
    public void Test_Day01_SumTotalDistance_FromTestFile_Star1()
    {
        var totalDistance = Day01.SumTotalDistance(Day01.GetFilePath(Day01.FileType.Test));
        
        Assert.Equal(11, totalDistance);
    }
    
    [Fact]
    public void Test_Day01_SumTotalDistance_FromDataFile_Star1()
    {
        var totalDistance = Day01.SumTotalDistance(Day01.GetFilePath(Day01.FileType.ChallengeData));
        
        Assert.Equal(2066446, totalDistance);
    }
    
    [Fact]
    public void Test_Day01_SimilarityScore_FromTestFile_Star2()
    {
        var similarityScore = Day01.CalculateSimilarityScore(Day01.GetFilePath(Day01.FileType.Test));
        
        Assert.Equal(31, similarityScore);
    }
    
    [Fact]
    public void Test_Day01_SimilarityScore_FromDataFile_Star2()
    {
        var similarityScore = Day01.CalculateSimilarityScore(Day01.GetFilePath(Day01.FileType.ChallengeData));
        
        Assert.Equal(24931009, similarityScore);
    }
}