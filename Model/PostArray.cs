namespace Model
{
    public class PostArray
    {
        private Post[] postCollection;
        private static int countOfCollections = 0;
        public int Length => postCollection.Length;
        public PostArray(int size, string text)
        {
            postCollection = new Post[size];
            countOfCollections++;
        }
        /// <summary>
        /// Конструктор без атрибутов
        /// </summary>
        public PostArray()
        {
            postCollection = new Post[0];
            countOfCollections++;
        }
        /// <summary>
        /// Конструктор 
        /// </summary>
        public PostArray(int sizeOfCollection)
        {
            if (sizeOfCollection < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(sizeOfCollection),"Кол-во элементов в коллекции не может быть отрицательными");
            }
            postCollection = new Post[sizeOfCollection];
            Random random = new Random();
            for (int i = 0; i < sizeOfCollection; i++)
            {
                postCollection[i] = new Post("", random.Next(1, 1000), random.Next(0, 1000), random.Next(0, 1000));
            }
            countOfCollections++;
        }
        public PostArray(PostArray currentPostArray)
        {
            postCollection = new Post[currentPostArray.Length];
            for (int i = 0; currentPostArray.Length > i; i++)
            {
                postCollection[i] = new Post(currentPostArray[i]);
            }
            countOfCollections++;
        }
        public static string ShowCollection(PostArray posts)
        {
            if (posts == null)
            {
                throw new ArgumentNullException(nameof(posts),"Коллекция не инициализирована");
            }
            if (posts.Length == 0)
            {
                throw new ArgumentException(nameof(posts), "Длина коллекции равна 0");
            }
            string result = "----------------------------------------------------------------------\n";
            for (int i = 0; i < posts.Length; i++)
            {
                result += Post.ShowInfoOfPost(posts[i]);
            }
            result += "----------------------------------------------------------------------";
            return result;
        }
        public Post this[int index]
        {
            get
            {
                if (index < 0 || index >= postCollection.Length)
                {
                    throw new IndexOutOfRangeException("Индекс за пределами массива");
                }
                return postCollection[index];
            }
            set
            {
                if (index < 0 || index >= postCollection.Length)
                {
                    throw new IndexOutOfRangeException("Индекс за пределами массива");
                }
                postCollection[index] = value ?? throw new ArgumentNullException(nameof(index), "Нельзя присвоить null");
            }
        }
        public static string ShowCountOfCollections()
        {
            return ($"Кол-во коллекций {countOfCollections}\n");
        }
        public static string ShowTotalCoefficient(PostArray posts)
        {
            double totalEngagement = 0;
            if (posts is null || posts.Length == 0)
            {
                return $"Общий коэффициент вовлечённости 0\n";
            }
            for(int i = 0; i < posts.Length; i++)
            {
                Post post = posts[i];
                
                if (post is not null)
                {
                    double countOfEngagement = (double)posts[i].Views / 1000;
                    countOfEngagement = Math.Round(countOfEngagement, 2);
                    totalEngagement += countOfEngagement;
                }
            }
            totalEngagement = Math.Round(totalEngagement/posts.Length, 2);
            return $"Общий коэффициент вовлечённости {totalEngagement}\n"; 
        }
    }
}

