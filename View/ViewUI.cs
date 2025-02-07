
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
        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static void ShowMessage(double message)
        {
            Console.WriteLine(message);
        }
        public static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("-------Параметры меню-------");
            Console.WriteLine("1 - Проверка реализации первой части");
            Console.WriteLine("2 - Проверка реализации второй части");
            Console.WriteLine("3 - Проверка реализации третьей части");
            Console.WriteLine("0 - Закончить работу");
        }
        public static void PrintMenu2Part()
        {
            Console.Clear();
            Console.WriteLine("-------Параметры меню-------");
            Console.WriteLine("1 - +1 Просмотр посту");
            Console.WriteLine("2 - +1 Реакция посту");
            Console.WriteLine("3 - Узнать есть ли у поста Комент или Реакция при ненулевых просмотрах");
            Console.WriteLine("4 - Узнать процент охвата аудитории");
            Console.WriteLine("5 - Вывести на экран выбранный элемент");
            Console.WriteLine("6 - Узнать процент охвата аудитории");
        }

    }
}
