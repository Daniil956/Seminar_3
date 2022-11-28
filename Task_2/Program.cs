Console.Clear();

int DataEntryXY(string str)
{
    Console.Write(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FindQvandrat(int x)
{
    if (x == 1) Console.WriteLine (" (x > 0)&&(y > 0)");
    if (x == 2) Console.WriteLine ("(x < 0)&&(y > 0)");
    if (x == 3) Console.WriteLine ("(x < 0)&&(y < 0)");
    if (x == 4) Console.WriteLine ("(x > 0)&&(y < 0)");
}






int x = DataEntryXY("Введите квадрата: ");
//Console.WriteLine(x);

FindQvandrat (x);
