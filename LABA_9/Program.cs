namespace LABA_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Post Post_1 = new Post(1, 2, 3);
            //Post_1.Show();
            //Post Post_2 = new Post(12, 1232, 33456);
            //Post_2.Show();
            //Post Post_3 = new Post(14, 267, 39876);
            //Post_3.Show();
            //Post Post_4 = new Post(671, 345, 37651);
            //Post_4.Show();
            //Post Post_5 = new Post(451, 7652, 67893);
            //Post_5.Show();

            Post Post_1 = new Post(1323, 2, 3);
            Post Post_2 = new Post("Pfkegf", 1000, 2, 3);
            Post Post_3 = new Post(Post_2);
            Post Post_4 = new Post(567, 234, 900);
            Post_1.ShowCoefficientOfEngagement();
            Post_2.ShowCoefficientOfEngagement();
            Post_3.ShowCoefficientOfEngagement();
            Post_4.ShowCoefficientOfEngagement();
        }
    }
}
