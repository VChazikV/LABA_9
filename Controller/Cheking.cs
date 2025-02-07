using Model;
using View;
namespace Controller
{
    public class Cheking
    {
        #region Создание Постов
        public static Post CreateNewPost(string name, int views, int comments, int reactions)
        {
            try
            {
                return new Post(name, views, comments, reactions);
            }
            catch (Exception ex)
            {
                ViewUI.ShowEror(ex.Message);
                return null;
            }
        }
        public static Post CreateNewPost()
        {
            return new Post();
        }
        public static Post CreateNewPost(Post post)
        {
            return new Post(post);
        }
        #endregion
        public static void ShowInfoOfPost(Post post)
        {
            try
            {
                string result = Post.ShowInfoOfPost(post);
                ViewUI.ShowMessage(result);
            }
            catch (Exception ex)
            {
                ViewUI.ShowEror(ex.Message);
            }
        }
        public static void ShowCoefficientOfEngagement(Post post)
        {
            try
            {
                string result = Post.ShowCoefficientOfEngagement(post);
                ViewUI.ShowMessage(result);
            }
            catch (Exception ex)
            {
                ViewUI.ShowEror(ex.Message);
            }
        }
        public static void ShowCoefficientOfEngagement(Post post, string text)
        {
            try
            {
                string result = post.ShowCoefficientOfEngagement();
                ViewUI.ShowMessage(result);
            }
            catch (Exception ex)
            {
                ViewUI.ShowEror(ex.Message);
            }
        }
        public static void ShowCountOfCollections()
        {
            try
            {
                string result = PostArray.ShowCountOfCollections();
                ViewUI.ShowMessage(result);
            }
            catch (Exception ex)
            {
                ViewUI.ShowEror(ex.Message);
            }
        }
        public static void ShowCountOfPosts()
        {
            try
            {
                string result = Post.ShowCountOfPosts();
                ViewUI.ShowMessage(result);
            }
            catch (Exception ex)
            {
                ViewUI.ShowEror(ex.Message);
            }
        }

        public static void ShowCollection(PostArray posts)
        {
            try
            {
                string result = PostArray.ShowCollection(posts);
                ViewUI.ShowMessage(result);
            }
            catch (Exception ex) 
            {
                ViewUI.ShowEror(ex.Message);
            }

        }
        public static Post Increments(Post post)
        {
            try
            {
                return(++post);
            }
            catch (Exception ex)
            {
                ViewUI.ShowEror(ex.Message);
                return null;
            }
        }
        public static int CheckIntBigger0(string text)//функция Проверки числа на целое и больше 0
        {
            int intNumber;//Входные данные(число больше 0)
            do
            {
                try
                {
                    ViewUI.ShowMessage(text);//Выводим сообщение о данных, которые надо получить
                    intNumber = int.Parse(Console.ReadLine());//Преобразуем в int
                    if (intNumber < 1)//если число не положительное
                    {
                        throw new ArgumentException();
                    }
                }
                catch (FormatException)//Если введено не целое число
                {
                    ViewUI.ShowMessage("Ошибка: введите целое число больше 0.");
                    intNumber = -1;
                }
                catch (ArgumentException)//Если введено не целое число
                {
                    ViewUI.ShowMessage("Ошибка(Введено не положительное число): введите целое число больше 0.");
                    intNumber = -1;
                }
                catch (OverflowException)//Если введено число слишком большое или слишком маленькое, выходит за пределы int
                {
                    ViewUI.ShowMessage($"Ошибка: Введённое число слишком большое или слишком маленькое." +
                        $"\nВведите число в пределах [{int.MinValue}, {int.MaxValue}]");
                    intNumber = -1;
                }
                catch (Exception ex)//Другие ошибки, которые могу появиться
                {
                    ViewUI.ShowMessage($"Неожиданная ошибка: {ex.Message}");
                    intNumber = -1;
                }
            } while (intNumber < 1);//Цикл работает пока не получит целое число больше 0
            return intNumber;//Возвращаем значение
        }//Блок-схема Есть+
        /// <summary>
        /// Метод преобразования формы слова
        /// </summary>
    }
}
