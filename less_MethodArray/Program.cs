int [] array = { 103 ,22 ,3 , 7, 4 ,35 ,64 ,7 ,86 };

int n = array.Length;
int find = 64;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}