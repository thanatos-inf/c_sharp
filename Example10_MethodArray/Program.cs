int[] array = { 1, 12, 14, 41, 56, 78, 14, 82, 9 };

int n = array.Length;
int find = 14;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}