namespace Difference_of_squares
{
    internal class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Введіть число N:");
            int N = int.Parse(Console.ReadLine());

            
            int sum = Enumerable.Range(1, N).Sum(); 
            int squareOfSum = sum * sum; 

            
            int sumOfSquares = Enumerable.Range(1, N).Select(x => x * x).Sum();

           
            int difference = squareOfSum - sumOfSquares;

            
            Console.WriteLine($"Різниця між квадратом суми і сумою квадратів перших {N} натуральних чисел: {difference}");
        }
    }
}
