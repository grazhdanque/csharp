/* //1st type 
void Method1()
{
    System.Console.WriteLine("Author;");
}

//Method1();

//2nd type
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
//Method2(msg:"test text");

void Method21(string msg, int count)
{
    int i=0;
    while (count>i)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg:"test text 2",count:4);//or Method21(count:4,msg:"test text 2")

//3rd type


int Method3()
{
    return DateTime.Now.Year;
}
//int aaa = Method3();
//System.Console.WriteLine(aaa);

//4th type



/* string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;    
}
string res = Method4(5,"ben");
    System.Console.WriteLine(res);
     */



/*     string Method4(int count, string text)
{
    for (int i =0, i< count, i++)
    {
        result = result + text;
    }
    return result;    
}
string res = Method4(5,"ben");
    System.Console.WriteLine(res);
     */

for (int i = 2; i<=10; i++)
{
    for (int j =2; j <=10; j++)
    {
        System.Console.WriteLine($"{i}*{j}={i*j}");
    }
}