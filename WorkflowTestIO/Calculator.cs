namespace WorkflowTestIO;

public static class Calculator
{
    public static int Calculate(string input)
    {
        if (input.Length == 0)
            return 0;

        int.TryParse(input,out int result);
        return result;
    }
}