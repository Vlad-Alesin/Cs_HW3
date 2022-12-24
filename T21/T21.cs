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

int x1=GetNumber("введите координату Х первой точки");
int y1=GetNumber("введите координату У первой точки");
int z1=GetNumber("введите координату z первой точки");
int x2=GetNumber("введите координату Х второй точки");
int y2=GetNumber("введите координату У второй точки");
int z2=GetNumber("введите координату z второй точки");

double rez = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));
Console.WriteLine(Math.Round(rez,2));