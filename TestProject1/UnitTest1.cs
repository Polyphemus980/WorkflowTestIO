using System.Runtime.CompilerServices;
using WorkflowTestIO;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var input = "";

        var result = Calculator.Calculate(input);
        
        Assert.Equal(0,result);
    }

    [Fact]
    public void Test2()
    {
        var input = "5";

        var result = Calculator.Calculate(input);
        
        Assert.Equal(5,result);
    }

    [Fact]
    public void Test3()
    {
        var input = "5,5";

        var result = Calculator.Calculate(input);
        
        Assert.Equal(10,result);
    }

    [Fact]
    public void Test4()
    {
        var input = "5" + Environment.NewLine + "5";
        var result = Calculator.Calculate(input);
        
        Assert.Equal(10,result);
    }
}