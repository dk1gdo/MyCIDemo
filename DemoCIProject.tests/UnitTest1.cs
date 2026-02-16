using DemoCIProject.Classes;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void AddZeros_Calc()
    {
        var calc = new Calc();
        Assert.Equal(0, calc.Add(0,0));
    }
}