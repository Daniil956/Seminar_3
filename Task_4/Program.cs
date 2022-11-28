int interNumber(string str)
{
    Console.Write(str);
    int numberX = Convert.ToInt32(Console.ReadLine());
    return numberX;
}

void sqrt (int x)
{
    x = (x *x );
    Console.Write(x + ", ");
} 


int x = interNumber("Введите число: ");
int index = 1;

while(index <= x)
{
    sqrt(index);
    index++ ; 
}
