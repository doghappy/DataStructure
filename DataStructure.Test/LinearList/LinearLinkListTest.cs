using DataStructure.LinearList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DataStructure.Test.LinearList
{
    [TestClass]
    public class LinearLinkListTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            var linkList = new LinearLinkList<int>();
            Assert.AreEqual(linkList.Head.Data, 0);
            Assert.IsNull(linkList.Head.Next);
        }

        [TestMethod]
        public void TestIndexer1()
        {
            var linkList = new LinearLinkList<int>();
            linkList.Insert(0, new LinearLinkListNode<int>(1));
            Assert.AreEqual(1, linkList[0].Data);
            Assert.IsNull(linkList[0].Next);
            Assert.AreEqual(1, linkList.Head.Next.Data);
        }

        [TestMethod]
        public void TestInsert1()
        {
            var linkList = new LinearLinkList<int>();
            linkList.Insert(0, new LinearLinkListNode<int>(1));
            linkList.Insert(1, new LinearLinkListNode<int>(2));
            linkList.Insert(2, new LinearLinkListNode<int>(3));
            Assert.AreEqual(1, linkList[0].Data);
            Assert.AreEqual(2, linkList[1].Data);
            Assert.AreEqual(3, linkList[2].Data);
            Assert.AreEqual(1, linkList.Head.Next.Data);
            Assert.AreEqual(2, linkList.Head.Next.Next.Data);
            Assert.AreEqual(3, linkList.Head.Next.Next.Next.Data);
            Assert.IsNull(linkList[2].Next);
        }

        [TestMethod]
        public void TestInsert2()
        {
            var linkList = new LinearLinkList<int>();
            linkList.Insert(0, new LinearLinkListNode<int>(1));
            linkList.Insert(0, new LinearLinkListNode<int>(2));
            Assert.AreEqual(2, linkList[0].Data);
            Assert.AreEqual(1, linkList[1].Data);
            Assert.IsNull(linkList[1].Next);
        }

        [TestMethod]
        public void TestInsert3()
        {
            var linkList = new LinearLinkList<int>();
            linkList.Insert(0, new LinearLinkListNode<int>(1));
            linkList.Insert(0, new LinearLinkListNode<int>(2));
            linkList.Insert(1, new LinearLinkListNode<int>(6));
            Assert.AreEqual(2, linkList[0].Data);
            Assert.AreEqual(6, linkList[1].Data);
            Assert.AreEqual(1, linkList[2].Data);
            Assert.IsNull(linkList[2].Next);
        }

        [TestMethod]
        public void TestInsert4()
        {
            var linkList = new LinearLinkList<int>();
            linkList.Insert(0, new LinearLinkListNode<int>(1));
            linkList.Insert(1, new LinearLinkListNode<int>(2));
            linkList.Insert(2, new LinearLinkListNode<int>(3));
            linkList.Insert(1, null);
            Assert.AreEqual(1, linkList[0].Data);
            Assert.IsNull(linkList[1]);
            Assert.AreEqual(linkList[0].Next, linkList[1]);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestDeleteAt0()
        {
            var linkList = new LinearLinkList<int>();
            linkList.DeleteAt(0);
        }

        [TestMethod]
        public void TestDeleteAt1()
        {
            var linkList = new LinearLinkList<int>();
            linkList.Insert(0, new LinearLinkListNode<int>(1));
            linkList.Insert(1, new LinearLinkListNode<int>(2));
            linkList.Insert(2, new LinearLinkListNode<int>(3));
            linkList.DeleteAt(0);
            Assert.AreEqual(2, linkList[0].Data);
            Assert.AreEqual(3, linkList[1].Data);
        }

        [TestMethod]
        public void TestDeleteAt2()
        {
            var linkList = new LinearLinkList<int>();
            linkList.Insert(0, new LinearLinkListNode<int>(1));
            linkList.Insert(1, new LinearLinkListNode<int>(2));
            linkList.Insert(2, new LinearLinkListNode<int>(3));
            linkList.DeleteAt(1);
            Assert.AreEqual(1, linkList[0].Data);
            Assert.AreEqual(3, linkList[1].Data);
        }

        [TestMethod]
        public void TestDeleteAt3()
        {
            var linkList = new LinearLinkList<int>();
            linkList.Insert(0, new LinearLinkListNode<int>(1));
            linkList.Insert(1, new LinearLinkListNode<int>(2));
            linkList.Insert(2, new LinearLinkListNode<int>(3));
            linkList.DeleteAt(2);
            Assert.AreEqual(1, linkList[0].Data);
            Assert.AreEqual(2, linkList[1].Data);
            Assert.IsNull(linkList[1].Next);
        }
    }
}
