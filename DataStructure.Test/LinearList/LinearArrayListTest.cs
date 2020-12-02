using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructure.LinearList;

namespace DataStructure.Test.LinearList
{
    [TestClass]
    public class LinearArrayListTest
    {
        [TestMethod]
        public void TestInit()
        {
            var linearArrayList = new LinearArrayList<int>(20);
            Assert.AreEqual(20, linearArrayList.MaxLength);
            Assert.AreEqual(0, linearArrayList.Length);
        }

        [TestMethod]
        public void Insert1Test()
        {
            var linearArrayList = new LinearArrayList<int>(20);
            linearArrayList.Insert(0, 2);
            Assert.AreEqual(1, linearArrayList.Length);
            Assert.AreEqual(2, linearArrayList[0]);
            Assert.AreEqual(20, linearArrayList.MaxLength);
        }

        [TestMethod]
        public void Insert2Test()
        {
            var linearArrayList = new LinearArrayList<int>(20);
            linearArrayList.Insert(0, 4);
            linearArrayList.Insert(1, 5);
            linearArrayList.Insert(2, 6);
            Assert.AreEqual(3, linearArrayList.Length);
            Assert.AreEqual(4, linearArrayList[0]);
            Assert.AreEqual(5, linearArrayList[1]);
            Assert.AreEqual(6, linearArrayList[2]);
            Assert.AreEqual(20, linearArrayList.MaxLength);
        }

        [TestMethod]
        public void Insert3Test()
        {
            var linearArrayList = new LinearArrayList<int>(20);
            linearArrayList.Insert(0, 4);
            linearArrayList.Insert(1, 5);
            linearArrayList.Insert(1, 6);
            Assert.AreEqual(3, linearArrayList.Length);
            Assert.AreEqual(4, linearArrayList[0]);
            Assert.AreEqual(6, linearArrayList[1]);
            Assert.AreEqual(5, linearArrayList[2]);
            Assert.AreEqual(20, linearArrayList.MaxLength);
        }

        [TestMethod]
        public void Remove1Test()
        {
            var linearArrayList = new LinearArrayList<int>(20);
            linearArrayList.Insert(0, 2);
            linearArrayList.Remove(0);
            Assert.AreEqual(0, linearArrayList.Length);
            Assert.AreEqual(20, linearArrayList.MaxLength);
        }

        [TestMethod]
        public void Remove2Test()
        {
            var linearArrayList = new LinearArrayList<int>(20);
            linearArrayList.Insert(0, 4);
            linearArrayList.Insert(1, 5);
            linearArrayList.Insert(2, 6);
            linearArrayList.Remove(1);
            Assert.AreEqual(2, linearArrayList.Length);
            Assert.AreEqual(4, linearArrayList[0]);
            Assert.AreEqual(6, linearArrayList[1]);
            Assert.AreEqual(20, linearArrayList.MaxLength);
        }

        [TestMethod]
        public void Remove3Test()
        {
            var linearArrayList = new LinearArrayList<int>(20);
            linearArrayList.Insert(0, 4);
            linearArrayList.Insert(1, 5);
            linearArrayList.Insert(2, 6);
            linearArrayList.Remove(2);
            Assert.AreEqual(2, linearArrayList.Length);
            Assert.AreEqual(4, linearArrayList[0]);
            Assert.AreEqual(5, linearArrayList[1]);
            Assert.AreEqual(20, linearArrayList.MaxLength);
        }
    }
}
