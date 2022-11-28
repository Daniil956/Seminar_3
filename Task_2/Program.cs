Console.Clear();

int DataEntryXY(string str)
{
    Console.Write(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FindQvandrat(int x, int y)
{
    if ((x > 0)&&(y > 0)) Console.WriteLine ("Это первый квадрат");
    if ((x < 0)&&(y > 0)) Console.WriteLine ("Это второй квадрат");
    if ((x < 0)&&(y < 0)) Console.WriteLine ("Это третий квадрат");
    if ((x > 0)&&(y < 0)) Console.WriteLine ("Это четвёртый квадрат");
}






int x = DataEntryXY("Введите координаты: x = ");
//Console.WriteLine(x);
int y = DataEntryXY("Введите координаты: y = ");
//Console.WriteLine(y);
FindQvandrat (x, y);
