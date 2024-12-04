namespace Stars.Day01;

public class Day01Test
{
    [Fact]
    public void Test_Day01_SumTotalDistance_FromFile_Star1()
    {
        var totalDistance = Day01.SumTotalDistance(Day01.GetFilePath(Day01.FileType.Test));
        
        Assert.Equal(11, totalDistance);
    }
}