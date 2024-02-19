Console.Clear();

//Console.SetCursorPosition(15, 15);
//System.Console.WriteLine("0");

int xa = 1;
int ya = 1;
int xb = 1;
int yb = 30;
int xc = 40;
int yc = 30;

Console.SetCursorPosition(xa, ya);
System.Console.WriteLine("0");
Console.SetCursorPosition(xb, yb);
System.Console.WriteLine("0");
Console.SetCursorPosition(xc, yc);
System.Console.WriteLine("0");

int x = xa, y = ya;
int count = 0;
while(count < 10000)
{
    int what = new Random().Next(0,3);
    if(what == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }
    if(what == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }
    if(what == 2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }
    Console.SetCursorPosition(x, y);
    System.Console.WriteLine("0");
    count++;
}