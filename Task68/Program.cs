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
    System.Console.WriteLine("Please enter n, m");
    int[] inputArray = SingleLineInput(2);
    return inputArray;
}

int AckermanFunction(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return AckermanFunction(n - 1, 1);
    }
    else
    {
        return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
    }
}

System.Console.Clear();
int[] numbers = EnterNumbers();
System.Console.WriteLine($"Ackerman function output = {AckermanFunction(numbers[0], numbers[1])}");