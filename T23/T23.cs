int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод!");
        }
    }

    return result;
}

int n=GetNumber("введите число");
int i=1;

Console.WriteLine("полученный результат");
while (i<=n)
{
    Console.WriteLine(Math.Pow(i,3));
    i++;
}

