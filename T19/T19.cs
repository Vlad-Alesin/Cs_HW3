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

int num=GetNumber("введите число");

string number=num.ToString();

int i=0;
int b=0;
while (i<=(number.Length/2))
{
    if (number[i]==number[number.Length-(i+1)])
    {
        i++; 
    }
        else 
    {
        b=1;
        Console.WriteLine("число не является полиномом");
        break;  
    }
}

if (b==0)
{
    Console.WriteLine("число является полиномом");
}
