int[] SingleLineInput(int reqSizeArray)
{
    int[] array;
    System.Console.WriteLine("Enter single line array with a \"space\"");
    do
    {
        array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
        if (array.Length != reqSizeArray)
        {
            System.Console.WriteLine("Wrong enter, please try again");
        }
    } while (array.Length != reqSizeArray);
    return array;
}
int[] EnterNumbers()
{
    System.Console.WriteLine("Please enter numbers");
    int[] inputArray = SingleLineInput(2);
    return inputArray;
}

int SumDiapNaturalNumbers(int start, int end)
{
    if (end == start)
    {
        return start;
    }
    return SumDiapNaturalNumbers(start, end - 1) + end;
}

System.Console.Clear();
int[] numbers = EnterNumbers();
System.Console.WriteLine($"Summ natural nambers = {SumDiapNaturalNumbers(numbers[0], numbers[1])}");