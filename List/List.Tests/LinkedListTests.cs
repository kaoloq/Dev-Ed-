using NUnit.Framework;
using System;

namespace List.Tests
{
    public class LinkedListTests
    {
        [TestCase(new int[] { 1, 2, 4, 1, 3, 1, 0 }, 1, new int[] { 1, 2, 4, 1, 3, 1, 0, 1 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 7, new int[] { 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { }, 1, new int[] { 1 })]
        public void AddTest(int[] array, int value, int[] arrayExpected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.Add(value);

            LinkedList actual = linkedList;

            LinkedList expected = new LinkedList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 2, 4, 1, 3, 1, 0 }, 1, new int[] { 1, 2, 4, 1, 3, 1, 0 })]
        [TestCase(new int[] { 3, 4, 5, 6, 7 }, 2, new int[] { 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { }, 1, new int[] { 1 })]
        public void InsertInStartTest(int[] array, int value, int[] arrayExpected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.InsertInStart(value);

            LinkedList actual = linkedList;

            LinkedList expected = new LinkedList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 1, 3, new int[] { 1, 2, 4, 1, 3, 1, 0 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 7, 5, new int[] { 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 7, 0, new int[] { 7, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { }, 1, 0, new int[] { 1 })]
        public void InsertTest(int[] array, int value, int index, int[] arrayExpected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.Insert(value, index);

            LinkedList actual = linkedList;

            LinkedList expected = new LinkedList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 1, 10)]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 7, -20)]
        public void InsertWrongIndexShouldThrowIndexOutOfRangeException(int[] array, int value, int index)
        {
            LinkedList linkedList = new LinkedList(array);
            Assert.Throws<IndexOutOfRangeException>(() => linkedList.Insert(value, index));
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, new int[] { 1, 2, 4, 3, 1 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, new int[] { 2, 3, 4, 5 })]
        [TestCase(new int[] { 2 }, new int[] { })]
        public void RemoveLastTest(int[] array, int[] arrayExpected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.RemoveLast();

            LinkedList actual = linkedList;

            LinkedList expected = new LinkedList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, new int[] { 2, 4, 3, 1, 0 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, new int[] { 3, 4, 5, 6 })]
        [TestCase(new int[] { 2 }, new int[] { })]
        public void RemoveFirstTest(int[] array, int[] arrayExpected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.RemoveFirst();

            LinkedList actual = linkedList;

            LinkedList expected = new LinkedList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { })]
        public void RemoveFirstShouldThrowIndexOutOfRangeException(int[] array)
        {
            LinkedList linkedList = new LinkedList(array);
            Assert.Throws<IndexOutOfRangeException>(() => linkedList.RemoveFirst());
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 5, new int[] { 1, 2, 4, 3, 1 })]
        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 3, new int[] { 1, 2, 4, 1, 0 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 1, new int[] { 2, 4, 5, 6 })]
        [TestCase(new int[] { 2 }, 0, new int[] { })]
        public void RemoveAtTest(int[] array, int index, int[] arrayExpected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.RemoveAt(index);

            LinkedList actual = linkedList;

            LinkedList expected = new LinkedList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 10)]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, -20)]
        public void RemoveAtWrongIndexShouldThrowIndexOutOfRangeException(int[] array, int index)
        {
            LinkedList linkedList = new LinkedList(array);
            Assert.Throws<IndexOutOfRangeException>(() => linkedList.RemoveAt(index));
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 1, new int[] { 1, 2, 4, 3, 1})]
        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 3, new int[] { 1, 2, 4 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 5, new int[] {  })]
        [TestCase(new int[] { 2 }, 0, new int[] { 2 })]
        public void RemoveLastNodesTest(int[] array, int n, int[] arrayExpected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.RemoveLastNodes(n);

            LinkedList expected = new LinkedList(arrayExpected);
            LinkedList actual = linkedList;           

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 1, new int[] { 2, 4, 3, 1, 0 })]
        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 3, new int[] { 3, 1, 0 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 5, new int[] { })]
        [TestCase(new int[] { 2 }, 0, new int[] { 2 })]
        public void RemoveStartNodesTest(int[] array, int n, int[] arrayExpected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.RemoveStartNodes(n);

            LinkedList expected = new LinkedList(arrayExpected);
            LinkedList actual = linkedList;

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 2, 3, 4, 5, 6 }, -20)]
        public void RemoveStartNodesShouldThrowIndexOutOfRangeException(int[] array, int n)
        {
            LinkedList linkedList = new LinkedList(array);
            Assert.Throws<ArgumentOutOfRangeException>(() => linkedList.RemoveStartNodes(n));
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 1, 3, new int[] { 1, 2, 4, 1, 0 })]
        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 3, 0, new int[] {  3, 1, 0 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 2, 3, new int[] { 2, 3, 4})]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 0, 3, new int[] { 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 2 }, 0, 0, new int[] { 2 })]
        public void RemoveNodesAtTest(int[] array, int n, int index, int[] arrayExpected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.RemoveNodesAt(n, index);

            LinkedList expected = new LinkedList(arrayExpected);
            LinkedList actual = linkedList;

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 3, 10)]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 3, -20)]
        public void RemoveNodesAtShouldThrowIndexOutOfRangeException(int[] array, int n , int index)
        {
            LinkedList linkedList = new LinkedList(array);
            Assert.Throws<IndexOutOfRangeException>(() => linkedList.RemoveNodesAt(n, index));
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, -10, 3)]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, -40, 3)]
        public void RemoveNodesAtShouldThrowArgumentOutOfRangeException(int[] array, int n, int index)
        {
            LinkedList linkedList = new LinkedList(array);
            Assert.Throws<ArgumentOutOfRangeException>(() => linkedList.RemoveNodesAt(n, index));
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 5, 0)]
        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 3, 3)]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 1, 3)]
        [TestCase(new int[] { 2 }, 0, 2)]
        public void GetTest(int[] array, int index, int expected)
        {
            LinkedList linkedList = new LinkedList(array);

            int actual = linkedList.Get(index);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 10)]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, -20)]
        public void GetWrongIndexShouldThrowIndexOutOfRangeException(int[] array, int index)
        {
            LinkedList linkedList = new LinkedList(array);
            Assert.Throws<IndexOutOfRangeException>(() => linkedList.Get(index));
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 5, 4, new int[] { 1, 2, 4, 3, 1, 4 })]
        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 3, -10, new int[] { 1, 2, 4, -10, 1, 0 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 0, 3, new int[] { 3, 3, 4, 5, 6 })]
        public void SetTest(int[] array, int index, int value, int[] arrayExpected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.Set(index, value);

            LinkedList expected = new LinkedList(arrayExpected);
            LinkedList actual = linkedList;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 0, 2)]
        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 6, 4)]
        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 10, 4)]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, -20, 4)]
        public void SetWrongIndexShouldThrowIndexOutOfRangeException(int[] array, int index, int value)
        {
            LinkedList linkedList = new LinkedList(array);
            Assert.Throws<IndexOutOfRangeException>(() => linkedList.Set(index, value));
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 4, 2)]
        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 0, 5)]
        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 1, 0)]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 1, -1)]
        [TestCase(new int[] { 2 }, 2, 0)]
        [TestCase(new int[] {  }, 2, -1)]
        public void FindIndexByValueTest(int[] array, int value, int expected)
        {
            LinkedList linkedList = new LinkedList(array);

            int actual = linkedList.FindIndexByValue(value);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3, 1, 0 }, new int[] { 0, 1, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 4, 3 }, new int[] { 3, 4, 2, 1 })]
        [TestCase(new int[] { 2 }, new int[] { 2 })]
        [TestCase(new int[] { }, new int[] { })]
        public void ReverseTest(int[] array, int[] arrayExpected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.Reverse();

            LinkedList actual = linkedList;
            LinkedList expected = new LinkedList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, -47, 20, 0 }, 20)]
        [TestCase(new int[] { 1, 2, -47, 20, 70 }, 70)]
        [TestCase(new int[] { 70, -4, 4, 3 }, 70)]
        [TestCase(new int[] { 2 }, 2)]
        [TestCase(new int[] { 2, 2, 2, 2, 2 }, 2)]
        public void FindMaxTest(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);

            int actual = linkedList.FindMax();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { })]
        public void FindMaxInEmptyListThrowIndexOutOfRangeException(int[] array)
        {
            LinkedList linkedList = new LinkedList(array);
            Assert.Throws<IndexOutOfRangeException>(() => linkedList.FindMax());
        }


        [TestCase(new int[] { 1, 2, -47, 20, 0 }, -47)]
        [TestCase(new int[] { 70, -4, 4, -29 }, -29)]
        [TestCase(new int[] {-50, 70, -4, 4, -29 }, -50)]
        [TestCase(new int[] { 2 }, 2)]
        [TestCase(new int[] { 2, 2, 2, 2, 2 }, 2)]
        public void FindMinTest(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);

            int actual = linkedList.FindMin();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, -47, 20, 0 }, 2)]
        [TestCase(new int[] { 70, -4, 4, -29 }, 3)]
        [TestCase(new int[] { 70, -4, 4, -29, 100 }, 3)]
        [TestCase(new int[] { -70, -4, 4, -29, 100 }, 0)]
        [TestCase(new int[] { 2 }, 0)]
        [TestCase(new int[] { }, -1)]
        [TestCase(new int[] { 2, 2, 2, 2, 2 }, 0)]
        public void FindIndexOfMinTest(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);

            int actual = linkedList.FindIndexOfMin();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, -47, 20, 0 }, 3)]
        [TestCase(new int[] { 70, -4, 4, -29 }, 0)]
        [TestCase(new int[] { 70, -4, 4, -29, 100 }, 4)]
        [TestCase(new int[] { 2 }, 0)]
        [TestCase(new int[] { }, -1)]
        [TestCase(new int[] { 2, 2, 2, 2, 2 }, 0)]
        public void FindIndexOfMaxTest(int[] array, int expected)
        {
            LinkedList linkedList = new LinkedList(array);

            int actual = linkedList.FindIndexOfMax();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 4, 1, 3, 1, 0, 1 }, 1, new int[] { 2, 4, 3, 0 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6, 7 }, 1, new int[] { 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6, 7, 1 }, 1, new int[] { 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6, 7, 1 }, 4, new int[] { 2, 3, 5, 6, 7, 1})]
        [TestCase(new int[] { 1, 1, 1, 1 }, 1, new int[] { })]
        [TestCase(new int[] { }, 1, new int[] { })]
        public void RemoveAllByValueTest(int[] array, int value, int[] arrayExpected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.RemoveAllByValue(value);

            LinkedList actual = linkedList;

            LinkedList expected = new LinkedList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, -47, 20, 0 }, -47, new int[] { 1, 2, 20, 0 })]
        [TestCase(new int[] { 1, 2, -47, 20, 0 }, 0, new int[] { 1, 2, -47, 20 })]
        [TestCase(new int[] { 70, -4, 4, -29 }, 70, new int[] { -4, 4, -29 })]
        [TestCase(new int[] { 70, -4, 4, -29, 100, 4, 4, 4 }, 3, new int[] { 70, -4, 4, -29, 100, 4, 4, 4 })]
        [TestCase(new int[] { 2 }, 0, new int[] { 2 })]
        [TestCase(new int[] { }, -1, new int[] { })]
        [TestCase(new int[] { 2, 2, 2, 2, 2, 7 }, 7, new int[] { 2, 2, 2, 2, 2 })]
        public void RemoveFirstElementByValueTest(int[] array, int value, int[] arrayExpected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.RemoveFirstElementByValue(value);

            LinkedList actual = linkedList;

            LinkedList expected = new LinkedList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, -47, 20, 0 }, new int[] { 3, 9, 2, -40 }, new int[] { 1, 2, -47, 20, 0, 3, 9, 2, -40 })]
        [TestCase(new int[] { 70, -4, 4, -29 }, new int[] { -4, 20, -2 }, new int[] { 70, -4, 4, -29, -4, 20, -2 })]
        [TestCase(new int[] { 70, -4, 4, -29, 100, 4, 4, 4 }, new int[] { 90, -3, -1 }, new int[] { 70, -4, 4, -29, 100, 4, 4, 4, 90, -3, -1 })]
        [TestCase(new int[] { }, new int[] { 2 }, new int[] { 2 })]
        public void AddListTest(int[] array, int[] arrayAdd, int[] arrayExpected)
        {
            LinkedList linkedList = new LinkedList(array);
            LinkedList addedList = new LinkedList(arrayAdd);
            LinkedList expected = new LinkedList(arrayExpected);

            linkedList.AddList(addedList);
            LinkedList actual = linkedList;


            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 3, 9, 2, -40 }, new int[] { 1, 2, -47, 20, 0 }, new int[] { 1, 2, -47, 20, 0, 3, 9, 2, -40 })]
        [TestCase(new int[] { -4, 20, -2 }, new int[] { 70, -4, 4, -29 }, new int[] { 70, -4, 4, -29, -4, 20, -2 })]
        [TestCase(new int[] { 90, -3, -1 }, new int[] { 70, -4, 4, -29, 100, 4, 4, 4 }, new int[] { 70, -4, 4, -29, 100, 4, 4, 4, 90, -3, -1 })]
        [TestCase(new int[] { }, new int[] { 2 }, new int[] { 2 })]
        public void InsertListInStartTest(int[] array, int[] arrayAdd, int[] arrayExpected)
        {
            LinkedList linkedList = new LinkedList(array);
            LinkedList insertedList = new LinkedList(arrayAdd);
            LinkedList expected = new LinkedList(arrayExpected);

            linkedList.InsertListInStart(insertedList);
            LinkedList actual = linkedList;


            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 9, 2, -40 }, new int[] { 1, 2, -47, 20, 0 }, 2, new int[] { 3, 9, 1, 2, -47, 20, 0, 2, -40 })]
        [TestCase(new int[] { -4, 20, -2 }, new int[] { 70, -4, 4, -29 }, 1, new int[] { -4, 70, -4, 4, -29, 20, -2 })]
        [TestCase(new int[] { 90, -3, -1 }, new int[] { 70, -4, 4, -29, 100, 4, 4, 4 }, 3, new int[] { 90, -3, -1, 70, -4, 4, -29, 100, 4, 4, 4 })]
        [TestCase(new int[] { }, new int[] { 2 }, 0, new int[] { 2 })]
        public void InsertListTest(int[] array, int[] arrayAdd, int index, int[] arrayExpected)
        {
            LinkedList linkedList = new LinkedList(array);
            LinkedList insertedList = new LinkedList(arrayAdd);
            LinkedList expected = new LinkedList(arrayExpected);

            linkedList.InsertList(insertedList, index);
            LinkedList actual = linkedList;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 90, -3, -1 }, new int[] { 70, -4, 4, -29 }, -10)]
        [TestCase(new int[] { 90, -3, -1 }, new int[] { 70, -4, 4, -29 }, 20)]
        public void InsertListListThrowIndexOutOfRangeException(int[] array, int[] arrayAdd, int index)
        {
            LinkedList linkedList = new LinkedList(array);
            LinkedList addedLinkedList = new LinkedList(arrayAdd);
            Assert.Throws<IndexOutOfRangeException>(() => linkedList.InsertList(addedLinkedList,index));
        }


        [TestCase(new int[] { 0, 1, 3, -5, 7, 2, 8, -3 }, new int[] { -5, -3, 0, 1, 2, 3, 7, 8 })]
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0 })]
        [TestCase(new int[] { 256, -25, 3, 0, 0 }, new int[] { -25, 0, 0, 3, 256 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        public void SortUpTests(int[] array, int[] arrayExpected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.SortUp();

            LinkedList actual = linkedList;
            LinkedList expected = new LinkedList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 1, 3, -5, 7, 2, 8, -3 },  new int[] { 8, 7, 3, 2, 1, 0, -3, -5 })]
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0 })]
        [TestCase(new int[] { 256, -25, 3, 0, 0 },  new int[] { 256, 3, 0, 0, -25 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        public void SortDownTests(int[] array, int[] arrayExpected)
        {
            LinkedList linkedList = new LinkedList(array);
            linkedList.SortDown();

            LinkedList actual = linkedList;
            LinkedList expected = new LinkedList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }

    }
}