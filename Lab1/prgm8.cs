class Array
{
    public void prgm8()
    {
        int[] arr = new int[100];
        Console.WriteLine("Enter array length:- ");
        int l = int.Parse(Console.ReadLine());
        for (int i = 0; i < l; i++)
        {
            Console.WriteLine("Enter array element:- ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Array elements:- ");
        for (int i = 0; i < l; i++)
        {
            Console.WriteLine(arr[i] + " ");
        }
    }
}