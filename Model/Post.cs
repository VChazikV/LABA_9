namespace Model
{
    public class Post
    {
        #region Атрибуты
        /// <summary>
        /// Название Поста
        /// </summary>
        string name;//Кол-во просмотров

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

        static int SUBSCRIBERS = 1000;//Константа для кол-во подписчиков

        static int countOfPosts = 0;//Кол-во постов

        static int countOfUnnamedPosts = 0;//Кол-во постов без названия
        #endregion

        #region Свойства
        /// <summary>
        /// Свойство для обработки бизнес-правил для кол-ва просмотров на посте
        /// </summary>
        public string Name
        {
            get => name;

            private set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    name = $"POST_{++countOfUnnamedPosts}";
                }
            }
        }
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
                    throw new ArgumentOutOfRangeException(nameof(Views), "Кол-во просмотров не может быть меньше 0");
                }
                numViews = value;
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
                    throw new ArgumentOutOfRangeException(nameof(Comments), "Кол-во комментариев не может быть меньше 0");
                }
                numComments = value;
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
                    throw new ArgumentOutOfRangeException(nameof(Reactions), "Кол-во реакций не может быть меньше 0");
                }
                numReactions = value;
            }
        }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор всех атрибутов
        /// </summary>
        public Post(string name, int numViews, int numComments, int numReactions)
        {
            Name = name;
            Views = numViews;
            Comments = numComments;
            Reactions = numReactions;
            countOfPosts++;
        }
        /// <summary>
        /// Конструктор без атрибутов
        /// </summary>
        public Post()
        {
            Name = "";
            Views = 0;
            Comments = 0;
            Reactions = 0;
            countOfPosts++;
        }
        /// <summary>
        /// Конструктор копирования
        /// </summary>
        public Post(Post p)
        {
            Name = p.Name;
            Views = p.Views;
            Comments = p.Comments;
            Reactions = p.Reactions;
            countOfPosts++;
        }
        #endregion


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
        public static void ShowInfoOfPostsNumber(Post post)
        {
            Console.WriteLine(
                $"------------------------------------\n" +
                $"{post.Name}\n" +
                $"{post.Views} {GetWordForm(post.Views, "просмотр", "просмотра", "просмотров")}.\n" +
                $"{post.Comments} {GetWordForm(post.Comments, "комментарий", "комментария", "комментариев")}.\n" +
                $"{post.Reactions} {GetWordForm(post.Reactions, "реакция", "реакции", "реакций")}.\n" +
                $"------------------------------------\n");
        }
        public string ShowInfoOfPostsName()
        {
            return Name;
        }
        /// <summary>
        /// Вывод информации о кол-ве объектов.
        /// </summary>
        public static void ShowCountOfPosts()
        {
            Console.WriteLine($"Кол-во постов {countOfPosts}\n");
        }
        /// <summary>
        /// Вывод информации о информации объекта.
        /// </summary>
        public void ShowCoefficientOfEngagement()
        {
            double countOfEngagement = (float)numViews / SUBSCRIBERS;
            countOfEngagement = Math.Round(countOfEngagement, 2);
            if (countOfEngagement > 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Коэффициент вовлечённости поста {name} равен {countOfEngagement}\n");
                Console.ResetColor();
            }
            else if (countOfEngagement < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Коэффициент вовлечённости поста {name} равен {countOfEngagement}\n");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"Коэффициент вовлечённости поста {name}  равен {countOfEngagement}\n");
            }
        }
        public static void ShowCoefficientOfEngagement(Post postCurrent)
        {
            double countOfEngagement = (double)postCurrent.Views / (double)SUBSCRIBERS;
            countOfEngagement = Math.Round(countOfEngagement, 2);
            if (countOfEngagement > 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Коэффициент вовлечённости поста {postCurrent.Name} равен {countOfEngagement}\n");
                Console.ResetColor();
            }
            else if (countOfEngagement < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Коэффициент вовлечённости поста {postCurrent.Name} равен {countOfEngagement}\n");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"Коэффициент вовлечённости поста {postCurrent.Name}  равен {countOfEngagement}\n");
            }
        }
        #region Операции 2 Часть
        public static Post operator ++(Post currentPost)
        {
            Post resultPost = new Post(currentPost);
            resultPost.Views = resultPost.Views + 1;
            return resultPost;
        }
        public static Post operator !(Post currentPost)
        {
            //Post resultPost = new Post(currentPost);
            //resultPost.Reactions = resultPost.Reactions + 1; //Этот вариант не работает из-за обработки оператора ! не как ++ и --
            //return resultPost;

            //Нарушим правила обработки унарных операций и будем изменять сам операнд
            currentPost.Reactions +=1;
            return currentPost;

        }
        public static explicit operator bool(Post currentPost)
        {
            return (currentPost.Views > 0) && (currentPost.Reactions >= 1 || currentPost.Comments >= 1);
        }
        public static implicit operator double(Post currentPost)
        {
            return Math.Round((double)currentPost.Views / (double)SUBSCRIBERS, 2);
        }
        public static bool operator ==(Post p1, Post p2)
        {
            return p1.Views == p2.Views && p1.Comments == p2.Comments && p1.Reactions == p2.Reactions;
        }
        public static bool operator !=(Post p1, Post p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (obj is not Post otherPost)
                return false;
            return Views == otherPost.Views &&
                   Comments == otherPost.Comments &&
                   Reactions == otherPost.Reactions &&
                   Name == otherPost.Name;
        }
        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Views, Comments, Reactions);
        //}
        #endregion
    }
}
