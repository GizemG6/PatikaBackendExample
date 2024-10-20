namespace FibonacciSequence
{
    public class Program
    {
        static void Main(string[] args) // 0, 1, 1, 2, 3, 5, 8, 13....
        {
            Console.WriteLine("Bir sayi giriniz:");
            int number = Convert.ToInt32(Console.ReadLine());
            Fibonacci(number);
        }

        static void Fibonacci(int input)
        {
            int ilk = 0;
            int ikinci = 1;
            int ucuncu = 0;

            Console.Write($"{ilk},{ikinci},");
            while (ucuncu <= input)
            {
                ucuncu = ilk + ikinci;
                if ( ucuncu > input)
                    break;
                Console.Write(ucuncu + ",");
                ilk = ikinci;
                ikinci = ucuncu;

            }

        }
    }
}
