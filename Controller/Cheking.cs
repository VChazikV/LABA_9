using Model;
using View;
namespace Controller
{
    public class Cheking
    {
        public static void CreateNewPost(string name, int views, int comments, int reactions)
        {
            try
            {
                Post post = new Post(name, views, comments, reactions);
                //Добавить в коллекцию
            }
            catch (Exception ex)
            {
                Class1.ShowEror(ex.Message);
            }
        }
        public static void CreateNewPost()
        {
            Post post = new Post();
            //Добавить в коллекцию
        }
        public static string ShowInfoOfPost()
        {
            //Сделать проверку орфографии
            return "ejj0";

        }
        /// <summary>
        /// Метод преобразования формы слова
        /// </summary>
        private static string GetWordForm(int countOfItem, string normal, string singlForm, string pluralForm)
        {
            string corectForm;
            countOfItem = Math.Abs(countOfItem) % 100;//countOfItem всегда не отрицательна, но для проверки добавим модуль
            int lastNumber = countOfItem % 10;
            if (countOfItem > 10 && countOfItem < 20)
            {
                corectForm = pluralForm;
            }
            else if (lastNumber >= 2 && lastNumber <= 4)
            {
                corectForm = singlForm;
            }
            else if (lastNumber == 1)
            {
                corectForm = normal;
            }
            else
            {
                corectForm = pluralForm;
            }
            return corectForm;
        }
    }
}
