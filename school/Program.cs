namespace school
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string error = ("Всем привет, сегодня я покушал и поиграл в игры. А еще я сходил в магазин и купил продукты");
            string correct = error.Replace("я", "ты");
            Console.WriteLine(correct);
        }
    }
}