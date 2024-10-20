namespace IsThatPalindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir string giriniz: ");
            string data = Console.ReadLine();
            bool dataReverse = Palindrome(data);
            if (dataReverse)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("palindrome değil");
            }

        }
        static bool Palindrome(string input)
        {
            int lenght = input.Length;

            for (int i = 0; i < lenght / 2; i++) // t-e-n-e-t --> t == t, e == e,
            {
                if (input[i] != input[lenght - i - 1])
                    return false;
                else
                    return true;
            }

            return true;
        }
    }
}
