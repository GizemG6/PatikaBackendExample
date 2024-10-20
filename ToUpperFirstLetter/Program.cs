namespace ToUpperFirstLetter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kelime giriniz:");
            string sentence = Console.ReadLine();
            string sentenceLower = sentence.ToLower();
            int length = sentenceLower.Length;
            string firstLetter = sentenceLower.Substring(0, 1).ToUpper();
            string otherLetter = sentenceLower.Substring(1, length-1);
            Console.WriteLine($"{firstLetter}{otherLetter}");
        }
    }
}
