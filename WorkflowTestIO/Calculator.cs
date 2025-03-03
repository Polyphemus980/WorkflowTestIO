namespace WorkflowTestIO;

public static class Calculator
{
    public static int Calculate(string input)
    {
        if (input.Length == 0)
            return 0;

        var splitInput = input.Split([",",Environment.NewLine], StringSplitOptions.None);
        return splitInput.Select(singleInput =>
        {
            int.TryParse(singleInput ,out int parsedInput);
            return parsedInput;
        }).Sum();
    }
}