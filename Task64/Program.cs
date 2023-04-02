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
int EnterNum()
{
    System.Console.WriteLine("Please enter nuber");
    int[] inputArray = SingleLineInput(1);
    return inputArray[0];
}

string ViewReversNaturalNumbers(int numbers)
{
    if (1 == numbers)
    {
        return numbers.ToString();
    }
    return numbers.ToString() + ", " + ViewReversNaturalNumbers(numbers - 1);
}

System.Console.Clear();
int number = EnterNum();
System.Console.WriteLine(ViewReversNaturalNumbers(number));