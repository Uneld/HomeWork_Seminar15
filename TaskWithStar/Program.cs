bool CheckSequence(string sequence)
{
    Stack<char> charsForCheck = new Stack<char>();

    foreach (char ch in sequence)
    {
        if (ch == '{' || ch == '(' || ch == '[')
        {
            charsForCheck.Push(ch);
        }
        else if (ch == '}' || ch == ')' || ch == ']')
        {
            if (charsForCheck.Count != 0)
            {
                switch (ch)
                {
                    case '}':
                        if (charsForCheck.Pop() != '{')
                        {
                            return false;
                        }
                        break;
                    case ']':
                        if (charsForCheck.Pop() != '[')
                        {
                            return false;
                        }
                        break;
                    case ')':
                        if (charsForCheck.Pop() != '(')
                        {
                            return false;
                        }
                        break;
                }
            }
            else
            {
                return false;
            }
        }
    }
    return charsForCheck.Count == 0;
}

string sequence = System.Console.ReadLine();
if (CheckSequence(sequence))
{
    System.Console.WriteLine($"Brackets sequence is correct");
}
else
{
    System.Console.WriteLine($"Brackets sequence is not correct");
}
