class Program
{
    public static void Main(string[] args)
    {
        int[] array = {5, 10, 2, 45, 91, 3, 20, 40, 30, 9, 8};
        List<int> resultArray = GetNumbers(array, 50, 5, 10);
        foreach (int singleNumber in resultArray) 
        {
            Console.WriteLine(singleNumber);    
        }
    }

    public static List<int> GetNumbers(int[] n, int a, int x, int y)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < n.Length; i++)
        {
            if ((n[i] < a) && (n[i] % x == 0) && (n[i] % y ==0))
            {
                result.Add(n[i]);
            }
        }
        return result;
    }
}