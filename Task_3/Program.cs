// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


int interXY(string str)
{
    Console.Write(str);
    int numberX = Convert.ToInt32(Console.ReadLine());
    return numberX;
}

void findLength(int x1, int y1, int x2, int y2)
{
    double length = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
    Console.WriteLine(length);
}


int x1 = interXY("Введите координату Х первой точки: ");
int y1 = interXY("Введите координату Y первой точки: ");
int x2 = interXY("Введите координату Х второй точки: ");
int y2 = interXY("Введите координату Y второй точки: ");

findLength(x1, y1, x2, y2);