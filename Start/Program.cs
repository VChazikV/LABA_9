using View;
using Controller;
using Model;
using Microsoft.VisualBasic;
using System;
namespace Start
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            string nextAction;
            bool continueRaning = true;
            do
            {
                ViewUI.PrintMenu();
                nextAction = Console.ReadLine();
                switch (nextAction)
                {
                    case "1":
                        //Если успею, добавить заготовку под второй уровень меню и сделать прогу для взаимодействия
                        PostArray posts_1 = new PostArray(3, "");
                        //Cheking.CreateNewCollection(8);
                        ViewUI.ShowMessage("Введите имя поста:");
                        string name = Console.ReadLine();
                        int views = Cheking.CheckIntBigger0("Введите количество просмотров:");
                        int comments = Cheking.CheckIntBigger0("Введите количество комментариев:");
                        int reactions = Cheking.CheckIntBigger0("Введите количество реакций:");
                        posts_1[0] = Cheking.CreateNewPost(name, views, comments, reactions);//конструктор с параметрами
                        posts_1[1] = Cheking.CreateNewPost();//Конструктор без параметров
                        posts_1[2] = Cheking.CreateNewPost(posts_1[0]);//Конструктор с копированием
                        Cheking.ShowCoefficientOfEngagement(posts_1[0]);//Коэффициент через static
                        Cheking.ShowCoefficientOfEngagement(posts_1[0], "");//Коэффициент ,tp static
                        Cheking.ShowCollection(posts_1);//Вывод
                        Cheking.ShowCountOfPosts();
                        Cheking.ShowCountOfCollections();
                        break;
                    case "2":
                        NextAction2PartMenu();
                        break;
                    case "3":
                        break;
                    case "0":
                        continueRaning = false;
                        Console.WriteLine("Работа программы завершена");
                        break;
                    default:
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
        static void NextAction2PartMenu()
        {
            bool continueRaning2Part = true;
            PostArray posts_2 = new PostArray(4, "");
            posts_2[0] = Cheking.CreateNewPost();
            posts_2[1] = Cheking.CreateNewPost(posts_2[0]);
            posts_2[2] = Cheking.CreateNewPost(posts_2[0]);
            posts_2[3] = Cheking.CreateNewPost(posts_2[0]);
            do
            {
                ViewUI.ShowMessage("Элементы коллекции");
                Cheking.ShowCollection(posts_2);
                int NumberOfPosts = Cheking.CheckIntBigger0("Выбери номер поста представленных выше с которым надо работать от 1 до 4")-1;
                ViewUI.PrintMenu2Part();
                string action = Console.ReadLine();
                
                try //Ловлю выход за пределы коллекции
                {
                    switch (action)//Выбор исполняемой функции
                    {
                        case "1":
                            ViewUI.ShowMessage("Было:");
                            Cheking.ShowInfoOfPost(posts_2[NumberOfPosts]++);
                            ViewUI.ShowMessage("Стало:");
                            Cheking.ShowInfoOfPost(posts_2[NumberOfPosts]);
                            break;
                        case "2":
                            ViewUI.ShowMessage("Было:");
                            Cheking.ShowInfoOfPost(posts_2[NumberOfPosts]);
                            ViewUI.ShowMessage("Стало:");
                            Cheking.ShowInfoOfPost(!posts_2[NumberOfPosts]);
                            break;
                        case "3":
                            if ((bool)posts_2[NumberOfPosts])
                            {
                                ViewUI.ShowMessage("Да, есть");
                            }
                            else
                            {
                                ViewUI.ShowMessage("Нет, нету");
                            }
                            break;
                        case "4":
                            ViewUI.ShowMessage(posts_2[NumberOfPosts]);
                            break;
                        case "5":
                            Cheking.ShowInfoOfPost(posts_2[NumberOfPosts]);
                            break;
                        case "0":

                            continueRaning2Part = false;
                            break;
                        default:

                            break;
                    }
                } catch (Exception ex)
                {
                    ViewUI.ShowMessage(ex.Message);
                }
                
            } while (continueRaning2Part);
            
        }
    }
}

