namespace Helpers;

public class FileIOTests
{
    
    [Fact]
    public void Test_FileIO_LoadTextFromFile_NoFile()
    {
        var emptyData = string.Empty;
        var resultData = FileIO.LoadTextFromFile("");
        
        Assert.Equal(emptyData, resultData);
    }
    
    [Fact]
    public void Test_FileIO_LoadTextFromFile()
    {
        var testDataPath = AppDomain.CurrentDomain.BaseDirectory + "assets/data/test-data.txt";
        var resultData = FileIO.LoadTextFromFile(testDataPath);
        
        Assert.NotEmpty(resultData);
        //Assert.Equal(13, resultData.Length);
    }
    
    
    [Fact]
    public void Test_FileIO_LoadTextLinesFromFile_NoFile()
    {
        var emptyData = new List<string>();
        var resultData = FileIO.LoadTextLinesFromFile("");
        
        Assert.Equal(emptyData, resultData);
    }

    [Fact]
    public void Test_FileIO_LoadTextLinesFromFile()
    {
        var testDataPath = AppDomain.CurrentDomain.BaseDirectory + "assets/data/test-data.txt";
        var resultData = FileIO.LoadTextLinesFromFile(testDataPath);
        
        Assert.NotEmpty(resultData);
        Assert.Equal(2, resultData.Count);
    }
    
    
    [Fact]
    public void Test_FileIO_Load2DStringArrayFromFile_NoFile()
    {
        var emptyData = new string[0, 0];
        var resultData = FileIO.Load2DStringArrayFromFile("");
        
        Assert.Equal(emptyData, resultData);
    }

    [Fact]
    public void Test_FileIO_Load2DStringArrayFromFile()
    {
        var testDataPath = AppDomain.CurrentDomain.BaseDirectory + "assets/data/test-2d-string-array.txt";
        var resultData = FileIO.Load2DStringArrayFromFile(testDataPath);
        
        Assert.Equal(2, resultData.Rank);
        Assert.Equal(10, resultData.GetLength(0));
        Assert.Equal(10, resultData.GetLength(1));
    }
    
    [Fact]
    public void Test_FileIO_Load2DLongArrayFromFile_NoFile()
    {
        var emptyData = new long[0, 0];
        var resultData = FileIO.Load2DLongArrayFromFile("");
        
        Assert.Equal(emptyData, resultData);
    }

    [Fact]
    public void Test_FileIO_Load2DLongArrayFromFile()
    {
        var testDataPath = AppDomain.CurrentDomain.BaseDirectory + "assets/data/test-2d-long-array.txt";
        var resultData = FileIO.Load2DLongArrayFromFile(testDataPath);
        
        Assert.Equal(2, resultData.Rank);
        Assert.Equal(2, resultData.GetLength(0));
        Assert.Equal(3, resultData.GetLength(1));
    }
}