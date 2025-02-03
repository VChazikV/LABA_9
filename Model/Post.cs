namespace Model
{
    public class Post
    {
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
        /// Конструктор без имени
        /// </summary>
        /// НЕ ИМЕЕТ СМЫСЛА
        //public Post(int numViews, int numComments, int numReactions)
        //{
        //    Name = "";
        //    Views = numViews;
        //    Comments = numComments;
        //    Reactions = numReactions;
        //    countOfPosts++;
        //}
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
            Name = "";
            Views = p.Views;
            Comments = p.Comments;
            Reactions = p.Reactions;
            countOfPosts++;
        }
        


        /// <summary>
        /// Вывод информации об объекте в формате "N просмотров. M комментариев. Z реакций."
        /// </summary>
        public int[] ShowInfoOfPostsNumber()
        {
            return [Views, Comments, Reactions];
            //    Console.WriteLine(
            //        $"------------------------------------\n"+
            //        $"{name}\n" +
            //        $"{numViews} {GetWordForm(numViews, "просмотр", "просмотра", "просмотров")}.\n" +
            //        $"{numComments} {GetWordForm(numComments, "комментарий", "комментария", "комментариев")}.\n" +
            //        $"{numReactions} {GetWordForm(numReactions, "реакция", "реакции", "реакций")}.\n" +
            //        $"------------------------------------\n");
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
            double countOfEngagement = (float)postCurrent.Views / SUBSCRIBERS;
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
    }
}
