namespace Stars.Day03;

public class Instruction
{
    public Type Type { get; set;  }
    public int Index { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
}

public enum Type
{
    Do, 
    Dont, 
    Multiplication
};