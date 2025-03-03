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
}