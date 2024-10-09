namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 8, 4, 36, 2, 9 };
            int min = Min(numbers);
            Console.WriteLine( min);
        }
        static int Min(int[] arr)
        {
            int min = arr[0] ;
            for (int i = 1;i< arr.Length;i++)
            {

                if (arr[i] < min)  
                {
                    min = arr[i];
                }
            }
            return min;

        }
    }
}
