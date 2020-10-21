using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList_DS;

namespace LinkedListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            LinkedList list = new LinkedList();
            list.Add(12);
            list.Add(30);
            list.Add(56);
            Assert.IsTrue(list.Search(30));
        }
    }
}
