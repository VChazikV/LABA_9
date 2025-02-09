using Model;
namespace Test;

[TestClass]
public class TestsPostArray
{
    [TestMethod]
    public void TestCreatePostArraySize()
    {
        PostArray posts = new PostArray(2);
    }
    [TestMethod]
    public void TestShowNullCollection()
    {
        PostArray posts = new PostArray(1, "");
        posts[0] = new Post("P", 0, 0, 0);
        string expextedMessage = $"----------------------------------------------------------------------\n" +
        $"------------------------------------\n" +
                $"P\n" +
                $"0 просмотров.\n" +
                $"0 комментариев.\n" +
                $"0 реакций.\n" +
                $"------------------------------------\n" +
                "----------------------------------------------------------------------";

        string testMessage = PostArray.ShowCollection(posts);

        Assert.AreEqual(expextedMessage, testMessage);
    }
    [TestMethod]
    public void TestShowTotalCoefficientOfEngagementCorrect()
    {
        PostArray posts = new PostArray(2, "");
        posts[0] = new Post("P", 1000, 123, 432);
        posts[1] = new Post("P", 1000, 123, 432);
        string testMessage;
        string expextedMessage = "Общий коэффициент вовлечённости 1\n";
        testMessage = PostArray.ShowTotalCoefficient(posts);
        Assert.AreEqual(expextedMessage, testMessage);
    }
    [TestMethod]
    public void TestShowTotalCoefficientOfEngagement0Length()
    {
        PostArray posts = new PostArray();
        string testMessage;
        string expextedMessage = "Общий коэффициент вовлечённости 0\n";
        //Act
        testMessage = PostArray.ShowTotalCoefficient(posts);
        //Assert
        Assert.AreEqual(expextedMessage, testMessage);
    }
    [TestMethod]
    public void TestShowTotalCoefficientOfEngagementNull()
    {
        PostArray posts = null;
        string testMessage;
        string expextedMessage = "Общий коэффициент вовлечённости 0\n";
        //Act
        testMessage = PostArray.ShowTotalCoefficient(posts);
        //Assert
        Assert.AreEqual(expextedMessage, testMessage);
    }
    [TestMethod]
    public void TestDeepCopied()
    {
        PostArray expextedCollection = new PostArray(4);
        PostArray testCollection = new PostArray(expextedCollection);
        bool checkingCorrectCopied = true;

        int i = 0;
        while (checkingCorrectCopied && i < testCollection.Length)
        {
            checkingCorrectCopied = testCollection[i].Equals(expextedCollection[i]);
            i++;
        }
        Assert.IsTrue(checkingCorrectCopied);

    }


    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestPostArrayExceptionSizeMinus()
    {
        // Act
        PostArray testPosts = new PostArray(-2);
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestPostArrayExceptionShowNullCollection()
    {
        // Act
        PostArray testPosts = null;

        PostArray.ShowCollection(testPosts);
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestPostArrayExceptionShow0Size()
    {
        // Act
        PostArray testPosts = new PostArray();

        PostArray.ShowCollection(testPosts);
    }
    [TestMethod]
    [ExpectedException(typeof(IndexOutOfRangeException))]
    public void TestSetIndexOutOfCollection()
    {
        // Act
        PostArray testPosts = new PostArray(3);
        testPosts[4] = new Post();
    }
    [TestMethod]
    [ExpectedException(typeof(IndexOutOfRangeException))]
    public void TestGetIndexOutOfCollection()
    {
        // Act
        PostArray testPosts = new PostArray(3);
        Post helpPosts = new Post(testPosts[4]);
    }

}
