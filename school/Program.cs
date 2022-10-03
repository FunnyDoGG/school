namespace school
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string error = Console.ReadLine();
            string correct = error.Replace("я", "ты");
            Console.WriteLine(correct);
        }
    }
}