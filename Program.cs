

using Altkom._26_28._02._2024.SOLID.L;


int a = 3;
int b = 5;

Rectangle rectangle = CreateRectangle(a, b);

Console.WriteLine($"{a} * {b} = {rectangle.Area}");





Rectangle CreateRectangle(int a, int b)
{
    return new Square() { A = a, B = b };
}


