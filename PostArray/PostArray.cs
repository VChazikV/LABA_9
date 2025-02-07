using Model;
namespace PostArrayCollection
{
    public class PostArray
    {
        private Post[] postCollection;
        private static int countOfCollections = 0;
        public int Length => postCollection.Length;
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
                throw new ArgumentOutOfRangeException(nameof(sizeOfCollection), "Кол-во элементов в коллекции не может быть отрицательными");
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
                postCollection[index] = value ?? throw new ArgumentNullException(nameof(value), "Нельзя присвоить null");
            }
        }
    }


}
