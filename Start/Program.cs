using View;
using Controller;
namespace Start
{
    internal class Program
    {
        public static void PrintMenu()
        {
            Console.WriteLine("-------Параметры меню-------");
            Console.WriteLine("1 - Добавить новый пост полностью");
            Console.WriteLine("2 - Добавить новый пост пустой");
            Console.WriteLine("3 - Добавить новый пост скопировав");
        }
        static void Main(string[] args)
        {
            PrintMenu();
            string nextAction = null;
            bool continueRaning = true;
            do
            {
                nextAction = Console.ReadLine();
                switch (nextAction)
                {
                    case "1":
                        Console.WriteLine("Введите имя поста:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введите количество просмотров:");
                        int views = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите количество комментариев:");
                        int comments = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите количество реакций:");
                        int reactions = int.Parse(Console.ReadLine());

                        Cheking.CreateNewPost(name, views, comments, reactions);
                        Console.WriteLine(Cheking.ShowInfoOfPost());
                        break;
                    case "2":
                        Cheking.CreateNewPost();
                        break;
                    case "3":
                        break;
                    case "0":
                        continueRaning = false;
                        Console.WriteLine("Работа программы завершена");
                        break;
                    default:
                        PrintMenu();
                        break;
                }
            } while (continueRaning);

            #region Проверка кол-ва постов статический метод(переменная)
            //Post.ShowCountOfPosts();
            //Post Post_1 = new Post();
            //Post.ShowCountOfPosts();
            //Post Post_2 = new Post();
            //Post.ShowCountOfPosts();
            //Post Post_3 = new Post();
            //Post.ShowCountOfPosts();
            //#endregion
            //#region Проверка перегрузок
            //Post Post_4 = new Post("Защита лаба 4 часть 1", 1234, 24, 67); // Перегрузка №1
            //Post_4.ShowInfoOfPosts();
            //Post Post_5 = new Post(543, 24, 67); // Перегрузка №2
            //Post_5.ShowInfoOfPosts();
            //Post Post_6 = new Post(); // Перегрузка №3
            //Post_6.ShowInfoOfPosts();
            //Post Post_7 = new Post(Post_4); // Перегрузка №3
            //Post_7.ShowInfoOfPosts();
            //#endregion
            //#region Проверка доступа
            //Post Post_Dostup = new Post();
            //Post_Dostup.ShowInfoOfPosts();
            //Post_Dostup.Views = 9112;
            //Post_Dostup.Name = "Ntcnbr";
            //Post_Dostup.Comments = 87;
            //Post_Dostup.Reactions = 62;
            //#endregion
            //#region Проверка падежей
            //Post Post_Padegh_1 = new Post(1, 1, 1);
            //Post Post_Padegh_2 = new Post(2, 2, 2);
            //Post Post_Padegh_9 = new Post(9, 9, 9);
            //#endregion
            //#region Метода в задачи #1
            //Post Post_Green = new Post(1962, 1, 1);
            //Post Post_Red = new Post(562, 2, 2);
            //Post Post_White = new Post(995, 9, 9);
            //Post_Green.ShowCoefficientOfEngagement();
            //Post_Red.ShowCoefficientOfEngagement();
            //Post_White.ShowCoefficientOfEngagement();
            //#endregion
            //Post.ShowCountOfPosts();
            ////Свойства методы желательно через return
            ////Исключения 
            //Post.ShowCoefficientOfEngagement(Post_4);
            #endregion
        }
    }
}
