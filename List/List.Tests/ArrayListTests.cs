using NUnit.Framework;
using System;

namespace List.Tests
{
    public class ArrayListTests
    {
        [TestCase(new int[] { 1, 2, 4, 1, 3, 1, 0 }, 1, new int[] { 1, 2, 4, 1, 3, 1, 0, 1 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 7, new int[] { 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { }, 1, new int[] { 1 })]
        //public void AddTest(int[] array, int value, int[] arrayExpected)
        public void AddTest(int[] array, int value, int[] arrayExpected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.Add(value);

            ArrayList actual = arrayList;

            ArrayList expected = new ArrayList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 2, 4, 1, 3, 1, 0 }, 1, new int[] { 1, 2, 4, 1, 3, 1, 0 })]
        [TestCase(new int[] { 3, 4, 5, 6, 7 }, 2, new int[] { 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { }, 1, new int[] { 1 })]
        public void InsertInStartTest(int[] array, int value, int[] arrayExpected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.InsertInStart(value);

            ArrayList actual = arrayList;

            ArrayList expected = new ArrayList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 1, 3, new int[] { 1, 2, 4, 1, 3, 1, 0 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 7, 4, new int[] { 2, 3, 4, 5, 7, 6 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 7, 0, new int[] { 7, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { }, 1, 0, new int[] { 1 })]
        public void InsertTest(int[] array, int value, int index, int[] arrayExpected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.Insert(value, index);

            ArrayList actual = arrayList;

            ArrayList expected = new ArrayList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 1, 10)]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 7, -20)]
        public void InsertWrongIndexShouldThrowIndexOutOfRangeException(int[] array, int value, int index)
        {
            ArrayList arrayList = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => arrayList.Insert(value, index));
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, new int[] { 1, 2, 4, 3, 1 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, new int[] { 2, 3, 4, 5 })]
        [TestCase(new int[] { 2 }, new int[] { })]
        public void RemoveLastTest(int[] array, int[] arrayExpected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.RemoveLast();

            ArrayList actual = arrayList;

            ArrayList expected = new ArrayList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, new int[] { 2, 4, 3, 1, 0 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, new int[] { 3, 4, 5, 6 })]
        [TestCase(new int[] { 2 }, new int[] { })]
        public void RemoveFirstTest(int[] array, int[] arrayExpected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.RemoveFirst();

            ArrayList actual = arrayList;

            ArrayList expected = new ArrayList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 5, new int[] { 1, 2, 4, 3, 1 })]
        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 3, new int[] { 1, 2, 4, 1, 0 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 1, new int[] { 2, 4, 5, 6 })]
        [TestCase(new int[] { 2 }, 0, new int[] { })]
        public void RemoveAtTest(int[] array, int index, int[] arrayExpected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.RemoveAt(index);

            ArrayList actual = arrayList;

            ArrayList expected = new ArrayList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 10)]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, -20)]
        public void RemoveAtWrongIndexShouldThrowIndexOutOfRangeException(int[] array, int index)
        {
            ArrayList arrayList = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => arrayList.RemoveAt(index));
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 5, 0)]
        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 3, 3)]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 1, 3)]
        [TestCase(new int[] { 2 }, 0, 2)]
        public void GetAtTest(int[] array, int index, int expected)
        {
            ArrayList arrayList = new ArrayList(array);

            int actual = arrayList.GetAt(index);


            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 10)]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, -20)]
        public void GetAtWrongIndexShouldThrowIndexOutOfRangeException(int[] array, int index)
        {
            ArrayList arrayList = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => arrayList.GetAt(index));
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 4, 2)]
        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 0, 5)]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 1, -1)]
        [TestCase(new int[] { 2 }, 2, 0)]
        public void FindIndexByValueTest(int[] array, int value, int expected)
        {
            ArrayList arrayList = new ArrayList(array);

            int actual = arrayList.FindIndexByValue(value);


            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 1, 0 }, 4, 2, new int[] { 1, 2, 4, 1, 0 })]
        [TestCase(new int[] { 1, 2, 4, 3, 1 }, 0, 4, new int[] { 1, 2, 4, 3, 0 })]
        [TestCase(new int[] { 2, 4, 5, 6 }, 3, 1, new int[] { 2, 3, 5, 6 })]
        [TestCase(new int[] { 2 }, 4, 0, new int[] { 4 })]
        public void SetTest(int[] array, int value, int index, int[] arrayExpected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.Set(value, index);

            ArrayList actual = arrayList;

            ArrayList expected = new ArrayList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 4, 3, 1, 0 }, 4, 10)]
        [TestCase(new int[] { 2, 3, 4, 5, 6 }, 3, -20)]
        public void SetWrongIndexShouldThrowIndexOutOfRangeException(int[] array, int value, int index)
        {
            ArrayList arrayList = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => arrayList.Set(value, index));
        }


        [TestCase(new int[] { 1, 2, 3, 1, 0 }, new int[] { 0, 1, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 4, 3 }, new int[] { 3, 4, 2, 1 })]
        [TestCase(new int[] { 2 }, new int[] { 2 })]
        [TestCase(new int[] { }, new int[] { })]
        public void ReverseTest(int[] array, int[] arrayExpected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.Reverse();

            ArrayList actual = arrayList;

            ArrayList expected = new ArrayList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, -47, 20, 0 }, 20)]
        [TestCase(new int[] { 70, -4, 4, 3 }, 70)]
        [TestCase(new int[] { 2 }, 2)]
        [TestCase(new int[] { 2, 2, 2, 2, 2 }, 2)]
        public void FindMaxTest(int[] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);

            int actual = arrayList.FindMax();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { })]
        public void FindMaxInEmptyListThrowIndexOutOfRangeException(int[] array)
        {
            ArrayList arrayList = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => arrayList.FindMax());
        }


        [TestCase(new int[] { 1, 2, -47, 20, 0 }, -47)]
        [TestCase(new int[] { 70, -4, 4, -29 }, -29)]
        [TestCase(new int[] { 2 }, 2)]
        [TestCase(new int[] { 2, 2, 2, 2, 2 }, 2)]
        public void FindMinTest(int[] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);

            int actual = arrayList.FindMin();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { })]
        public void FindMinInEmptyListThrowIndexOutOfRangeException(int[] array)
        {
            ArrayList arrayList = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => arrayList.FindMin());
        }


        [TestCase(new int[] { 1, 2, -47, 20, 0 }, 3)]
        [TestCase(new int[] { 70, -4, 4, -29 }, 0)]
        [TestCase(new int[] { 70, -4, 4, -29, 100 }, 4)]
        [TestCase(new int[] { 2 }, 0)]
        [TestCase(new int[] { }, -1)]
        [TestCase(new int[] { 2, 2, 2, 2, 2 }, 0)]
        public void FindIndexOfMaxTest(int[] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);

            int actual = arrayList.FindIndexOfMax();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, -47, 20, 0 }, 2)]
        [TestCase(new int[] { 70, -4, 4, -29 }, 3)]
        [TestCase(new int[] { 70, -4, 4, -29, 100 }, 3)]
        [TestCase(new int[] { 2 }, 0)]
        [TestCase(new int[] { }, -1)]
        [TestCase(new int[] { 2, 2, 2, 2, 2 }, 0)]
        public void FindIndexOfMinTest(int[] array, int expected)
        {
            ArrayList arrayList = new ArrayList(array);

            int actual = arrayList.FindIndexOfMin();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 4, 1, 3, 1, 0, 1 }, 1, new int[] { 2, 4, 3, 0 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6, 7 }, 1, new int[] { 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { }, 1, new int[] { })]
        public void RemoveAllElementsByValueTest(int[] array, int value, int[] arrayExpected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.RemoveAllElementsByValue(value);

            ArrayList actual = arrayList;

            ArrayList expected = new ArrayList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, -47, 20, 0 }, -47, new int[] { 1, 2, 20, 0 })]
        [TestCase(new int[] { 70, -4, 4, -29 }, 70, new int[] { -4, 4, -29 })]
        [TestCase(new int[] { 70, -4, 4, -29, 100, 4, 4, 4 }, 3, new int[] { 70, -4, 4, -29, 100, 4, 4, 4 })]
        [TestCase(new int[] { 2 }, 0, new int[] { 2 })]
        [TestCase(new int[] { }, -1, new int[] {})]
        [TestCase(new int[] { 2, 2, 2, 2, 2, 7 }, 7, new int[]  { 2, 2, 2, 2, 2 } )]
        public void RemoveFirstElementByValueTest(int[] array, int value, int[] arrayExpected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.RemoveFirstElementByValue(value);

            ArrayList actual = arrayList;

            ArrayList expected = new ArrayList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, -47, 20, 0 }, new int[] { 3, 9, 2, -40 }, new int[] { 1, 2, -47, 20, 0, 3, 9, 2, -40 })]
        [TestCase(new int[] { 70, -4, 4, -29 }, new int[] { -4, 20, -2 }, new int[] { 70, -4, 4, -29, -4, 20, -2 })]
        [TestCase(new int[] { 70, -4, 4, -29, 100, 4, 4, 4 }, new int[] { 90, -3, -1}, new int[] { 70, -4, 4, -29, 100, 4, 4, 4, 90, -3, -1 })]
        [TestCase(new int[] { }, new int[] { 2 }, new int[] { 2 })]
        public void AddListTest(int[] array, int[] arrayAdd , int[] arrayExpected)
        {
            ArrayList arrayList = new ArrayList(array);
            ArrayList arrayAddList = new ArrayList(arrayAdd);
            ArrayList expected = new ArrayList(arrayExpected);

            arrayList.AddList(arrayAddList);
            ArrayList actual = arrayList;


            Assert.AreEqual(expected, actual);
        }


        [TestCase( new int[] { 3, 9, 2, -40 }, new int[] { 1, 2, -47, 20, 0 }, new int[] { 1, 2, -47, 20, 0, 3, 9, 2, -40 })]
        [TestCase( new int[] { -4, 20, -2 }, new int[] { 70, -4, 4, -29 }, new int[] { 70, -4, 4, -29, -4, 20, -2 })]
        [TestCase( new int[] { 90, -3, -1 }, new int[] { 70, -4, 4, -29, 100, 4, 4, 4 }, new int[] { 70, -4, 4, -29, 100, 4, 4, 4, 90, -3, -1 })]
        [TestCase(new int[] { }, new int[] { 2 }, new int[] { 2 })]
        public void InsertListInStartTest(int[] array, int[] arrayAdd, int[] arrayExpected)
        {
            ArrayList arrayList = new ArrayList(array);
            ArrayList arrayAddList = new ArrayList(arrayAdd);
            ArrayList expected = new ArrayList(arrayExpected);

            arrayList.InsertListInStart(arrayAddList);
            ArrayList actual = arrayList;


            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 9, 2, -40 }, new int[] { 1, 2, -47, 20, 0 }, 2,  new int[] { 3, 9,  1, 2, -47, 20, 0 ,2, -40 })]
        [TestCase(new int[] { -4, 20, -2 }, new int[] { 70, -4, 4, -29 }, 1, new int[] { -4, 70, -4, 4, -29, 20, -2 })]
        [TestCase(new int[] { 90, -3, -1 }, new int[] { 70, -4, 4, -29, 100, 4, 4, 4 }, 3, new int[] { 90, -3, -1, 70, -4, 4, -29, 100, 4, 4, 4 })]
        [TestCase(new int[] { }, new int[] { 2 }, 0,  new int[] { 2 })]
        public void InsertListTest(int[] array, int[] arrayAdd, int index, int[] arrayExpected)
        {
            ArrayList arrayList = new ArrayList(array);
            ArrayList arrayAddList = new ArrayList(arrayAdd);
            ArrayList expected = new ArrayList(arrayExpected);

            arrayList.InsertList(arrayAddList, index);
            ArrayList actual = arrayList;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 4, 1, 3, 1, 0, 1 }, new int[] { 1, 2, 4, 1, 3, 1, 0, 1 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6, 7 }, new int[] { 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { }, new int[] { })]
        public void GetAllTest(int[] array, int[] arrayExpected)
        {
            ArrayList arrayList = new ArrayList(array);
            arrayList.GetAll();

            ArrayList actual = arrayList;

            ArrayList expected = new ArrayList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }



        [TestCase(new int[] { 0, 1, 3, -5, 7, 2, 8, -3}, new int[] { -5, -3, 0, 1, 2, 3, 7, 8 })]
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0 })]
        [TestCase(new int[] { 256, -25, 3, 0, 0 }, new int[] { -25, 0, 0, 3, 256 })]
        [TestCase(new int[] { }, new int[] {  })]
        [TestCase(new int[] { 1}, new int[] {1 })]     
        public void SortUpTests(int[] array, int[] arrayExpected)
        {
            ArrayList arrayList = new ArrayList(array);

            arrayList.SortUp(0, arrayList.Length);

            ArrayList actual = arrayList;

            ArrayList expected = new ArrayList(arrayExpected);

            Assert.AreEqual(expected, actual);
        }

    }
}