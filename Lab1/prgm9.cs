class ArrayMaxEle
{
    public void prgm9()
    {
        int[] arr = new int[100];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter array elements: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Max in array is " + getMax(arr));
    }
    public int getMax(int[] arr)
    {
        int max = int.MinValue;
        for (int i = 0; i < 5; i++)
        {
            max = max < arr[i] ? arr[i] : max;
        }
        return max;
    }
}