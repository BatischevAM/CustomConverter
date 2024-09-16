using CustomConverter;
class Program
{
    static void Main()
    {
        CustomConverter_ converter = new CustomConverter_();

        string IntInput = "123";
        converter.Convert(IntInput, out int IntResult);
        Console.WriteLine($"Convert '{IntInput}' in int: {IntResult}");

        string DoubleInput = "123,45";
        converter.Convert(DoubleInput, out double DoubleResult);
        Console.WriteLine($"Convert '{DoubleInput}' in double: {DoubleResult}");

        string BoolInput = "true";
        converter.Convert(BoolInput, out bool BoolResult);
        Console.WriteLine($"Convert '{BoolInput}' in bool: {BoolResult}");
        Console.ReadKey();
    }
}

