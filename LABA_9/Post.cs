using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_9
{
    internal class Post
    {
        /// <summary>
        /// Просмотры
        /// </summary>
        int numViews;//Кол-во просмотров

        /// <summary>
        /// Комментарии
        /// </summary>
        int numComments;//Кол-во комментариев

        /// <summary>
        /// Реакции
        /// </summary>
        int numReactions;//Кол-во реакций

        static int countOfPosts = 0;//Кол-во постов


        /// <summary>
        /// Свойство для обработки бизнес-правил для кол-ва просмотров на посте
        /// </summary>
        public int Views
        {
            get => numViews;

            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Кол-во просмотров не может быть меньше 0");
                    numViews = 0;
                }
                else
                {
                    numViews = value;
                }

            }
        }

        /// <summary>
        /// Свойство для обработки бизнес-правил для кол-ва комментариев на посте
        /// </summary>
        public int Comments
        {
            get => numComments;

            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Кол-во комментариев не может быть меньше 0");
                    numComments = 0;
                }
                else
                {
                    numComments = value;
                }

            }
        }

        /// <summary>
        /// Свойство для обработки бизнес-правил для кол-ва реакций на посте
        /// </summary>
        public int Reactions
        {
            get => numReactions;

            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Кол-во реакций не может быть меньше 0");
                    numReactions = 0;
                }
                else
                {
                    numReactions = value;
                }
            }
        }

        public Post(int numViews, int numComments, int numReactions)
        {
            Views = numViews;
            Comments = numComments;
            Reactions = numReactions;
            countOfPosts++;
        }
        public Post()
        {
            Views = 0;
            Comments = 0;
            Reactions = 0;
            countOfPosts++;
        }

        public Post(Post p)
        {
            Views = p.Views;
            Comments = p.Comments;
            Reactions= p.Reactions;
            countOfPosts++;
        }

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

        /// <summary>
        /// Вывод информации об объекте в формате "N просмотров. M комментариев. Z реакций."
        /// </summary>
        public void ShowInfoOfPosts()
        {
            Console.WriteLine($"{numViews} {GetWordForm(numViews, "просмотр", "просмотра", "просмотров")}.\n" +
                $"{numComments} {GetWordForm(numComments, "комментарий", "комментария", "комментариев")}.\n" +
                $"{numReactions} {GetWordForm(numReactions, "реакция", "реакции", "реакций")}.\n");
        }
        /// <summary>
        /// Вывод информации о кол-ве объектов."
        /// </summary>
        public static void ShowCountOfPosts()
        {
            Console.WriteLine($"Кол-во постов {countOfPosts}\n");
        }
    }
}
