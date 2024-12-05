﻿namespace Stars.Day02;

public class Day02Test
{
    [Fact]
    public void Test_Day02_CountSafeReports_FromTestFile_Star1()
    {
        var safeReports = Day02.CountSafeReports(Day02.GetFilePath(Day02.FileType.Test));
        
        Assert.Equal(2, safeReports);
    }
}