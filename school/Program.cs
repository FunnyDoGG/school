namespace school
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int origWidth, width;
            origWidth = Console.WindowWidth;
            string text = Console.ReadLine();
            int length = text.Length;
            width = origWidth / 2 + length / 2;
            Console.WriteLine(text.PadLeft(width));
            Console.ReadKey(true);
        }
    }
}