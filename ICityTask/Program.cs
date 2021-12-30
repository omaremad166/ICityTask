class ICityTask
{
    public static int GetRepeated1(int[] arr)
    {
        HashSet<int> unique = new();

        for (int i = 0; i < arr.Length; i++)
        {
            if (unique.Contains(arr[i]))
                return arr[i];
            else
                unique.Add(arr[i]);
        }

        return -1;
    }

    public static int GetRepeated2(int[] arr)
    {
        int[] newArr = new int[arr.Length - 1];

        for (int i = 0;i < arr.Length;i++)
        {
            if(newArr[arr[i]-1] == 0)
                newArr[arr[i]-1] = arr[i];
            else
                return arr[i];
        }

        return -1;
    }

    public static void Main()
    {
        int[] arr = { 4, 4, 5, 2, 1, 6, 3 };

        Console.WriteLine(GetRepeated2(arr));
    }
}
