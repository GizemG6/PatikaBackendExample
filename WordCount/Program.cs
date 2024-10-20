namespace WordCount
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz:"); //" yarın evi temizledikten sonra markete gideceğim " 
            string sentence = Console.ReadLine();
            string sentenceTrim = sentence.Trim();
            string[] data = sentenceTrim.Split(' ');
            
            int length = data.Length;
            Console.WriteLine($"Yazdiginiz cümledeki kelime sayisi: {length}");
        }
    }
}
