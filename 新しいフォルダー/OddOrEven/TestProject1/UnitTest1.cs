using MyConsoleNameSpace;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Pass()
        {
            Assert.Pass();
        }
        [Test]
        public void TestAdd()
        {
            MyConsoleApp myApp = new MyConsoleApp();
            int result = myApp.Add(2, 3);

            // Assert
            Assert.AreEqual(5, result);
        }
    }
}