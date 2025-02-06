
namespace View
{
    public class ViewUI
    {
        public static void ShowEror(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ошибка: {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void PrintMenu()
        {
            Console.WriteLine("-------Параметры меню-------");
            Console.WriteLine("1 - Добавить новый пост полностью");
            Console.WriteLine("2 - Добавить новый пост пустой");
            Console.WriteLine("3 - Добавить новый пост скопировав");
        }


    }
}
