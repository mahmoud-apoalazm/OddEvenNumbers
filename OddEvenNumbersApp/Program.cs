internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = {1,2,3,4,5,6,7,8,9};
        PrintNumbers("Numbers", numbers);
        PrintNumbers("Even No", numbers.Where(x=>IsEven(x)));
        PrintNumbers("Odd N", numbers.Where(x => IsOdd(x)));
    }
    static void PrintNumbers(string title,IEnumerable<int> numbers)
    {
        Console.Write($"{title} [ ");
        foreach (int number in numbers)
        {
            Console.Write($"{number}");
        }
        Console.Write(" ] ");

    }
    static bool IsEven(int number)=> number %2 ==0 ;

    static bool IsOdd(int number)=> !IsEven(number) ;

}