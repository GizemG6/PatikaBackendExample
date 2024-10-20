namespace NumberOfDigits
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz:");
            //string number = Console.ReadLine();
            //int result = NumberOfDigit(number);
            //Console.WriteLine($"Girdiginiz sayı {result} basamaklıdır.");
            int number = int.Parse(Console.ReadLine());
            int result = NumberOfDigit(number);
            Console.WriteLine(result);
        }

        // string ile
        /*static int NumberOfDigit(string input)
        {
            int length = input.Length;
            if (input.Contains("-") || input.Contains("+"))
                return length - 1;
            else
                return length;
        }*/

        // int ile
        static int NumberOfDigit(int input)
        {
            int i = 0;
            if (input < 0)
            {
                while (!(input >= 0))
                {
                    int inputKalan = input % 10;
                    int inputBolum = input / 10;
                    input = inputBolum;
                    i++;
                }
                return i;
            }
            else
            {
                while (!(input <= 0))
                {
                    int inputKalan = input % 10;
                    int inputBolum = input / 10;
                    input = inputBolum;
                    i++;
                }
                return i;
            }
        }
        
    }
}
