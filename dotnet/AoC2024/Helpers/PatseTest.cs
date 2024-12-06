namespace Helpers;

public class PatseTest
{
    [Fact]
    public void Test_Parse_Load2DStringArrayFromTextLines_Empty()
    {
        var emptyInput = new List<string>();
        var emptyResult = new string [0, 0];
        var resultData = Parse.Load2DStringArrayFromTextLines(emptyInput);
        
        Assert.Equal(emptyResult, resultData);
    }

    [Fact]
    public void Test_Parse_Load2DStringArrayFromTextLines()
    {
        var lines = new List<string>
        {
            "467..114..",
            "...*......",
            "..35..633.",
            "......#...",
            "617*......",
            ".....+.58.",
            "..592.....",
            "......755.",
            "...$.*....",
            ".664.598.."
        };

        var resultData = Parse.Load2DStringArrayFromTextLines(lines);
        
        Assert.Equal(2, resultData.Rank);
        Assert.Equal(10, resultData.GetLength(0));
        Assert.Equal(10, resultData.GetLength(1));
    }

    [Fact]
    public void Test_Parse_Load2DLongArrayFromTextLines_Empty()
    {
        var emptyInput = new List<string>();
        var emptyResult = new long [0, 0];
        var resultData = Parse.Load2DLongArrayFromTextLines(emptyInput);
        
        Assert.Equal(emptyResult, resultData);
    }
    
    [Fact]
    public void Test_Parse_Load2DLongArrayFromTextLines()
    {
        var lines = new List<string>
        {
            "50 98 2 ",
            "52 50 48"
        };

        var resultData = Parse.Load2DLongArrayFromTextLines(lines);
        
        Assert.Equal(2, resultData.Rank);
        Assert.Equal(2, resultData.GetLength(0));
        Assert.Equal(3, resultData.GetLength(1));
    }
}