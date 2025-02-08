using Model;
namespace Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestIncrement()
        {
            //Arrange
            Post testPost = new Post();
            Post expextedPost = new Post("POST_1", 1, 0, 0);
            //Act
            testPost++;
            //Assert
            Assert.IsTrue(expextedPost.Equals(testPost));
        }
    }
}
