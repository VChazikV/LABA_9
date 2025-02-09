using Model;
namespace Test
{
    [TestClass]
    public class TestsPost
    {

        [TestMethod]
        public void TestIncrementView()
        {
            //Arrange
            Post testPost = new Post();
            Post expextedPost = new Post("POST_1", 1, 0, 0);
            //Act
            testPost++;
            //Assert
            Assert.IsTrue(expextedPost.Equals(testPost));
        }
        [TestMethod]
        public void TestIncrementReactions()
        {
            //Arrange
            Post helpPost = new Post("POST_1", 0, 0, 0);
            Post expextedPost = new Post("POST_1", 0, 0, 1);
            //Act
            Post testPost = new Post(!helpPost);
            //Assert
            Assert.IsTrue(expextedPost.Equals(testPost));
        }
        [TestMethod]
        public void TestShowNullPost()
        {
            //Arrange
            string testMessage;
            string expextedMessage = "";
            //Act
            testMessage = Post.ShowInfoOfPost(null);
            //Assert
            Assert.IsTrue(expextedMessage.Equals(testMessage));
        }

        [TestMethod]
        public void TestShowPost()
        {
            //Arrange
            Post testPost = new Post("POST_1", 0, 0, 0);
            string testMessage;
            string expextedMessage = $"------------------------------------\n" +
                $"POST_1\n" +
                $"0 просмотров.\n" +
                $"0 комментариев.\n" +
                $"0 реакций.\n" +
                $"------------------------------------\n";
            //Act
            testMessage = Post.ShowInfoOfPost(testPost);
            //Assert
            Assert.IsTrue(expextedMessage.Equals(testMessage));
        }

        [TestMethod]
        public void TestShowCoefficientOfEngagementGreen()
        {
            //Arrange
            Post testPost = new Post("P", 2110, 123, 432);
            string testMessage;
            string expextedMessage = "Коэффициент вовлечённости поста P равен 2,11\n";
            //Act
            testMessage = Post.ShowCoefficientOfEngagement(testPost);
            //Assert
            Assert.AreEqual(expextedMessage, testMessage);
        }

        [TestMethod]
        public void TestShowCoefficientOfEngagementRed()
        {
            Post testPost = new Post("P", 110, 123, 432);
            string testMessage;
            string expextedMessage = "Коэффициент вовлечённости поста P равен 0,11\n";
            //Act
            testMessage = Post.ShowCoefficientOfEngagement(testPost);
            //Assert
            Assert.AreEqual(expextedMessage, testMessage);
        }

        [TestMethod]
        public void TestShowCoefficientOfEngagementWhite()
        {
            Post testPost = new Post("P", 1000, 123, 432);
            string testMessage;
            string expextedMessage = "Коэффициент вовлечённости поста P равен 1\n";
            //Act
            testMessage = Post.ShowCoefficientOfEngagement(testPost);
            //Assert
            Assert.AreEqual(expextedMessage, testMessage);
        }

        [TestMethod]
        public void TestExplicitBoolTrue()
        {
            // Arrange
            Post testPost = new Post("P", 1, 1, 1);
            bool testBool;
            bool expectedBool = true;

            // Act
            testBool = (bool)testPost;

            // Assert
            Assert.AreEqual(expectedBool, testBool);
        }

        [TestMethod]
        public void TestExplicitBoolFalseCommentsReactions()
        {
            // Arrange
            Post testPost = new Post("P", 1, 0, 0);
            bool testBool;
            bool expectedBool = false;

            // Act
            testBool = (bool)testPost;

            // Assert
            Assert.AreEqual(expectedBool, testBool);
        }

        [TestMethod]
        public void TestExplicitBoolFalseViews()
        {
            // Arrange
            Post testPost = new Post("P", 0, 0, 0);
            bool testBool;
            bool expectedBool = false;

            // Act
            testBool = (bool)testPost;

            // Assert
            Assert.AreEqual(expectedBool, testBool);
        }

        [TestMethod]
        public void TestImplisitDouble()
        {
            // Arrange
            Post testPost = new Post("P", 2111, 0, 0);
            double testDouble;
            double expectedDouble = 2.11;

            // Act
            testDouble = testPost;

            // Assert
            Assert.AreEqual(expectedDouble, testDouble);
        }

        [TestMethod]
        public void TestEqulsPostsTrue()
        {
            //Arrange
            bool testbool = true;
            Post test_1Post = new Post("POST_1", 0, 0, 0);
            Post test_2Post = new Post("POST_1", 0, 0, 0);
            //Act
            bool check = test_1Post == test_2Post;
            //Assert
            Assert.AreEqual(testbool, check);
        }

        [TestMethod]
        public void TestEqulsPostsFalse()
        {
            //Arrange
            bool testbool = false;
            Post test_1Post = new Post("POST_2", 0, 0, 0);
            Post test_2Post = new Post("POST_1", 0, 0, 0);
            //Act
            bool check = test_1Post == test_2Post;
            //Assert
            Assert.AreEqual(testbool, check);
        }

        [TestMethod]
        public void TestUnEqulsPostsTrue()
        {
            //Arrange
            bool testbool = true;
            Post test_1Post = new Post("POST_2", 0, 0, 0);
            Post test_2Post = new Post("POST_1", 0, 0, 0);
            //Act
            bool check = test_1Post != test_2Post;
            //Assert
            Assert.AreEqual(testbool, check);
        }

        [TestMethod]
        public void TestUnEqulsPostsFalse()
        {
            //Arrange
            bool testbool = false;
            Post test_1Post = new Post("POST_1", 0, 0, 0);
            Post test_2Post = new Post("POST_1", 0, 0, 0);
            //Act
            bool check = test_1Post != test_2Post;
            //Assert
            Assert.AreEqual(testbool, check);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestPostExceptionViews()
        {
            // Act
            Post testPokemon = new Post("P", -1, 0, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestPostExceptionReactions()
        {
            // Act
            Post testPokemon = new Post("P", 0, -1, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestPostExceptionComments()
        {
            // Act
            Post testPokemon = new Post("P", 0, 0, -1);
        }

    }
}
