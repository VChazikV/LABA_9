namespace View
{
    public class Class1
    {
        public static void ShowEror(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ошибка: {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
