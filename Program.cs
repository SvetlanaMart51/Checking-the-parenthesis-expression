// See https://aka.ms/new-console-template for more information

string stringInput;
int currentDepth = 0;
int maxDepth = 0;

Console.WriteLine("Здравствуйте. Введите строку скобок для поверки(строка может состоять только из скобок):");
stringInput = Console.ReadLine();

if (stringInput[0] == ')')
{
    Console.WriteLine("Ошибка! Правильное скобочное выражение не может начинаться с закрытой скобки");
}
else
{
    foreach(char bracket in stringInput)
    {
        if(bracket == '(' && currentDepth >= 0)
        {
            currentDepth++;
            if(maxDepth < currentDepth)
            {
                maxDepth++;
            }
        }
        else if (bracket == ')' && currentDepth >= 0)
        {
            currentDepth--;
        }
        else if (currentDepth < 0)
        {
            Console.WriteLine("Нарушена последовательность.");
            break;
        }
    }

    if (currentDepth == 0)
    {
        Console.WriteLine("Верное скобочное выражение. Все верно");
    }
    else
    {
        Console.WriteLine("Не верное скобочное выражение. Ошибка");
    }

}