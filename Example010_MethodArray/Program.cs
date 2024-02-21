int[] array = {1,2,3,4,5,56,67,78,8,56};

int n = array.Length;
int find = 56;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}