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

/* for (int i = 2; i<=10; i++)
{
    for (int j =2; j <=10; j++)
    {
        System.Console.WriteLine($"{i}*{j}={i*j}");
    }
} */

/* string text = "– Я думаю, – сказал князь, улыбаясь, – что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string txt, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = txt.Length;
    for (int i = 0; i < length; i++)
    {
        if (txt[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{txt[i]}";
    }
    return result;
}
string text1 = Replace(text, ' ', '|');
text1 = Replace(text1, 'к', 'К');
text1 = Replace(text1, 'С', 'с');
System.Console.WriteLine(text1); */


int [] arr = {1,4,35,23,6,3,67,4,3,6,8};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);

void SelectionSort(int[] array)
{
    for (int i = 0; i< array.Length -1;i++)
    {
        int minPos = i;
        for (int j = i+1; j< array.Length; j++)
        {
            if (array[j]<array[minPos]) minPos = j;
        }
        int temp = array[i];
        array[i] = array[minPos];
        array[minPos]=temp;
    }
}
SelectionSort(arr);
PrintArray(arr);