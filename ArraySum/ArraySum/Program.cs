int[] array = new int[] { 1, 2, 3, 4 };

for(int i = 0; i < array.Length; i++)
{
    for(int j = 0; j < array.Length; j++)
    {
        int sum;
        sum = array[i] + array[j];
        Console.WriteLine(sum);
    }
}