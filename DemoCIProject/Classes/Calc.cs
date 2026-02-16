namespace DemoCIProject.Classes;

public class Calc
{
    public int Add(int a, int b)
    {
        if (a == 0)
            throw new ArgumentOutOfRangeException(nameof(a));
        return a + b;
    }
}