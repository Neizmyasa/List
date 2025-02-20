﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace List.Tests
{
    public class DoubleLinkedListTests
    {
        [TestCase(new int[] { 1, 2, 3, 4 }, 8, new int[] { 1, 2, 3, 4, 8 })]
        [TestCase(new int[0], 3, new int[] { 3 })]
        [TestCase(new int[] { 0 }, 8, new int[] { 0, 8 })]
        public void AddTest(int[] inputArray, int value, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);

            actual.Add(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 8, new int[] { 8, 1, 2, 3, 4 })]
        [TestCase(new int[0], 3, new int[] { 3 })]
        [TestCase(new int[] { 1 }, 3, new int[] { 3, 1 })]
        public void AddAtFirstIndexTest(int[] inputArray, int value, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);

            actual.AddAtFirstIndex(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 11, 0, new int[] { 11, 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 22, 1, new int[] { 1, 22, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 22, 4, new int[] { 1, 2, 3, 4, 22 })]
        [TestCase(new int[0], 11, 0, new int[] { 11 })]
        public void AddAtIndexTest(int[] inputArray, int value, int index, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);

            actual.AddAtIndex(value, index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 33, -1)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 33, 5)]
        [TestCase(new int[0], 33, 1)]
        public void AddAtIndex_WhenIndexOutOfRange_IndexOutOfRangeException(int[] inputArray, int value, int index)
        {
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);
            try
            {
                actual.AddAtIndex(value, index);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 1 })]
        [TestCase(new int[] { 1 }, new int[0])]
        public void RemoveTest(int[] inputArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);

            actual.Remove();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]
        public void Remove_WhenArrayIsEmpty_Exception(int[] inputArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);
            try
            {
                actual.Remove();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 2, 3, 4 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 2 })]
        [TestCase(new int[] { 1 }, new int[0])]
        public void RemoveAtFirstIndexTest(int[] inputArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);

            actual.RemoveAtFirstIndex();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]
        public void RemoveAtFirstIndex_WhenArrayIsEmpty_Exception(int[] inputArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);
            try
            {
                actual.RemoveAtFirstIndex();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 0, new int[] { 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 3, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1 }, 0, new int[0])]
        public void RemoveByIndexTest(int[] inputArray, int index, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);

            actual.RemoveByIndex(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0], 0)]
        public void RemoveByIndex_WhenArrayIsEmpty_Exception(int[] inputArray, int index)
        {
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);
            try
            {
                actual.RemoveByIndex(index);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, -1)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 4)]
        public void RemoveByIndex_WhenIndexOutOfRange_IndexOutOfRangeException(int[] inputArray, int index)
        {
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);
            try
            {
                actual.RemoveByIndex(index);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8)]
        [TestCase(new int[0], 0)]
        [TestCase(new int[] { 1 }, 1)]
        public void GetLengthTest(int[] inputArray, int expected)
        {
            DoubleLinkedList list = new DoubleLinkedList(inputArray);
            int actual = list.Length;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 3, new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 0, new int[] { 1, 2, 3, 4 })]
        //[TestCase(new int[] { 1 }, 1, new int[0])]
        public void RemoveLastValuesTest(int[] inputArray, int count, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);

            actual.RemoveLastValues(count);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, -5)]
        public void RemoveLastValues_WhenCountArgumentIsLessThanZero_ArgumentException(int[] inputArray, int count)
        {
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);
            try
            {
                actual.RemoveLastValues(count);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[0], 0)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 10)]
        public void RemoveLastValues_WhenListIsLessThanCountOrEmpty_Exception(int[] inputArray, int count)
        {
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);
            try
            {
                actual.RemoveLastValues(count);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 3, new int[] { 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 0, new int[] { 1, 2, 3, 4 })]
        //[TestCase(new int[] { 1, 2, 3, 4 }, 4, new int[0])]
        //[TestCase(new int[] { 1 }, 1, new int[0])]
        public void RemoveFirstValuesTest(int[] inputArray, int count, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);

            actual.RemoveFirstValues(count);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, -5)]
        public void RemoveFirstValues_WhenCountArgumentIsLessThanZero_ArgumentException(int[] inputArray, int count)
        {
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);
            try
            {
                actual.RemoveFirstValues(count);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[0], 10)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 10)]
        public void RemoveFirstValues_WhenListIsLessThanCountOrEmpty_Exception(int[] inputArray, int count)
        {
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);
            try
            {
                actual.RemoveFirstValues(count);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 0, 3, new int[] { 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 1, 3, new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 3, 0, new int[] { 1, 2, 3, 4 })]
        //[TestCase(new int[] { 1, 2, 3, 4 }, 0, 4, new int[0])]
        public void RemoveValuesByIndexTest(int[] inputArray, int index, int count, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);

            actual.RemoveValuesByIndex(index, count);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0], 0, 0)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 1, -1)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 1, 4)]
        public void RemoveValuesByIndex_WhenIndexOutOfRange_IndexOutOfRangeException(int[] inputArray, int count, int index)
        {
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);
            try
            {
                actual.RemoveValuesByIndex(count, index);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, -5, 0)]
        public void RemoveValuesByIndex_WhenCountArgumentIsLessThanZero_ArgumentException(int[] inputArray, int count, int index)
        {
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);
            try
            {
                actual.RemoveValuesByIndex(count, index);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 20, 0)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 3, 2)]
        [TestCase(new int[0], 10, 0)]
        public void RemoveValuesByIndex_WhenSubArrayIsLessThanCountOrArrayIsEmpty_Exception(int[] inputArray, int count, int index)
        {
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);
            try
            {
                actual.RemoveValuesByIndex(count, index);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, 0, 1)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 3, 4)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 1, 2)]
        public void GetValueByIndexTest(int[] inputArray, int index, int expected)
        {
            DoubleLinkedList list = new DoubleLinkedList(inputArray);

            int actual = list[index];

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0], 0)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 4)]
        [TestCase(new int[] { 1, 2, 3, 4 }, -4)]
        public void GetValueByIndex_WhenIndexOutOfRange_IndexOutOfRangeException(int[] inputArray, int index)
        {
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);
            try
            {
                int value = actual[index];
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 0, 5, new int[] { 5, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 3, 33, new int[] { 1, 2, 3, 33, 5, 6 })]
        [TestCase(new int[] { 1 }, 0, 33, new int[] { 33 })]
        public void SetValueByIndexTest(int[] inputArray, int index, int value, int[] expectedList)
        {
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);
            DoubleLinkedList expected = new DoubleLinkedList(expectedList);

            actual[index] = value;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0], 0, 5)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 4, 7)]
        [TestCase(new int[] { 1, 2, 3, 4 }, -4, 9)]
        public void SetValueByIndex_WhenIndexOutOfRange_IndexOutOfRangeException(int[] inputArray, int index, int value)
        {
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);
            try
            {
                actual[index] = value;
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 1, 2, 3, 4 }, 1, 0)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 5, -1)]
        [TestCase(new int[] { 2, 4, 6, 7, 1 }, 1, 4)]
        [TestCase(new int[] { 5, 6, 0, 3, 0 }, 0, 2)]
        [TestCase(new int[0], 1, -1)]
        public void GetFirstIndexByValue(int[] inputArray, int value, int expected)
        {
            DoubleLinkedList list = new DoubleLinkedList(inputArray);

            int actual = list.GetFirstIndexByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 2, 1 })]
        [TestCase(new int[0], new int[0])]
        public void ReverseTest(int[] inputArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);

            actual.Reverse();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 1, 2, 3, 4, 4 }, 4)]
        [TestCase(new int[] { 1, 1, 90, 3, 4 }, 90)]
        [TestCase(new int[] { 0 }, 0)]
        public void GetMaxValueTest(int[] inputArray, int expected)
        {
            DoubleLinkedList list = new DoubleLinkedList(inputArray);

            int actual = list.GetMaxValue();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]
        public void GetMaxValue_WhenArrayIsEmpty_Exception(int[] inputArray)
        {
            DoubleLinkedList list = new DoubleLinkedList(inputArray);
            try
            {
                list.GetMaxValue();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 1, 2, 3, 4 }, 4)]
        [TestCase(new int[] { 1, 1, 90, 3, -4 }, 2)]
        [TestCase(new int[] { 0 }, 0)]
        public void GetIndexOfMaxValueTest(int[] inputArray, int expected)
        {
            DoubleLinkedList list = new DoubleLinkedList(inputArray);

            int actual = list.GetIndexOfMaxValue();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]
        public void GetIndexOfMaxValue_WhenArrayIsEmpty_Exception(int[] inputArray)
        {
            DoubleLinkedList list = new DoubleLinkedList(inputArray);
            try
            {
                list.GetIndexOfMaxValue();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 1, 2, 3, 4 }, 1)]
        [TestCase(new int[] { 1, 1, 90, 3, -4 }, -4)]
        [TestCase(new int[] { 0 }, 0)]
        public void GetMinValueTest(int[] inputArray, int expected)
        {
            DoubleLinkedList list = new DoubleLinkedList(inputArray);

            int actual = list.GetMinValue();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]
        public void GetMinValue_WhenArrayIsEmpty_Exception(int[] inputArray)
        {
            DoubleLinkedList list = new DoubleLinkedList(inputArray);
            try
            {
                list.GetMinValue();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 1, 2, 3, 4 }, 0)]
        [TestCase(new int[] { 1, 1, 90, 3, -4 }, 4)]
        [TestCase(new int[] { 0 }, 0)]
        public void GetIndexOfMinValueTest(int[] inputArray, int expected)
        {
            DoubleLinkedList list = new DoubleLinkedList(inputArray);

            int actual = list.GetIndexOfMinValue();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]
        public void GetIndexOfMinValue_WhenArrayIsEmpty_Exception(int[] inputArray)
        {
            DoubleLinkedList list = new DoubleLinkedList(inputArray);
            try
            {
                list.GetIndexOfMinValue();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 10, 1, 100, 3, -4 }, new int[] { -4, 1, 3, 10, 100 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 1, 2 })]
        [TestCase(new int[0], new int[0])]
        public void SortAscendingTest(int[] inputArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);

            actual.SortAscending();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 10, 1, 100, 3, -4 }, new int[] { 100, 10, 3, 1, -4 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[0], new int[0])]
        public void SortDescendingTest(int[] inputArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);

            actual.SortDescending();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 1, 2, 3, 4 }, 1, 0)]
        [TestCase(new int[] { 1, 1, 90, 3, -4 }, -4, 4)]
        [TestCase(new int[] { 1, 55 }, 55, 1)]
        [TestCase(new int[] { 1, 55 }, 1, 0)]
        [TestCase(new int[] { 0 }, 0, 0)]
        [TestCase(new int[0], 10, -1)]
        public void RemoveFirstByValueTest(int[] inputArray, int value, int expected)
        {
            DoubleLinkedList arrList = new DoubleLinkedList(inputArray);

            int actual = arrList.RemoveFirstByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 1, 2, 3, 4 }, 1, 2)]
        [TestCase(new int[] { 1, 1, 2, 3, 4, 1 }, 1, 3)]
        [TestCase(new int[] { 1, 1, 1, 1 }, 1, 4)]
        [TestCase(new int[] { 1, 1, 90, 3, -4 }, 100, 0)]
        [TestCase(new int[] { 1, 55 }, 55, 1)]
        [TestCase(new int[] { 1, 55 }, 1, 1)]
        [TestCase(new int[] { 0 }, 0, 1)]
        [TestCase(new int[0], 10, 0)]
        public void RemoveAllByValueTest(int[] inputArray, int value, int expected)
        {
            DoubleLinkedList arrList = new DoubleLinkedList(inputArray);

            int actual = arrList.RemoveAllByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0], new int[] { -4, 1, 3, 10, 100 }, new int[] { -4, 1, 3, 10, 100 })]
        [TestCase(new int[] { 1 }, new int[] { 1, 8, 9, 10 }, new int[] { 1, 1, 8, 9, 10 })]
        [TestCase(new int[0], new int[0], new int[0])]
        [TestCase(new int[] { 1, 2, 3 }, new int[0], new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 15 }, new int[] { 12 }, new int[] { 15, 12 })]
        public void AddListTest(int[] inputArray, int[] additionalArray, int[] expectedArray)
        {
            DoubleLinkedList additionalList = new DoubleLinkedList(additionalArray);
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);

            actual.AddList(additionalList);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 })]
        public void AddList_WhenArgumentIsNull_NullReferenceException(int[] inputArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);
            try
            {

                actual.AddList(null);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[0], new int[] { -4, 1, 3, 10, 100 }, new int[] { -4, 1, 3, 10, 100 })]
        [TestCase(new int[] { 1 }, new int[] { 1, 8, 9, 10 }, new int[] { 1, 8, 9, 10, 1 })]
        [TestCase(new int[] { 1 }, new int[] { 8 }, new int[] { 8, 1 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[0], new int[] { 1, 2, 3 })]
        [TestCase(new int[0], new int[0], new int[0])]
        public void AddListAtBeginningTest(int[] inputArray, int[] additionalArray, int[] expectedArray)
        {
            DoubleLinkedList additionalList = new DoubleLinkedList(additionalArray);
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);

            actual.AddListAtBeginning(additionalList);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 })]
        public void AddListAtBeginning_WhenArgumentIsNull_NullReferenceException(int[] inputArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);
            try
            {

                actual.AddListAtBeginning(null);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[0], new int[] { -4, 1, 3, 10, 100 }, 0, new int[] { -4, 1, 3, 10, 100 })]
        [TestCase(new int[] { -4, 1, 3, 10, 100 }, new int[] { 600, 700 }, 0, new int[] { 600, 700, -4, 1, 3, 10, 100 })]
        [TestCase(new int[] { -4, 1, 3, 10, 100 }, new int[] { 600, 700 }, 2, new int[] { -4, 1, 600, 700, 3, 10, 100 })]
        [TestCase(new int[] { -4, 1, 3, 10, 100 }, new int[] { 600, 700 }, 5, new int[] { -4, 1, 3, 10, 100, 600, 700 })]
        [TestCase(new int[] { 1 }, new int[] { 1, 8, 9, 10 }, 0, new int[] { 1, 8, 9, 10, 1 })]
        [TestCase(new int[0], new int[0], 0, new int[0])]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 3, 3, 3 }, 3, new int[] { 1, 2, 3, 3, 3, 3, 4, 5, 6, 7 })]
        public void AddListByIndexTest(int[] inputArray, int[] additionalArray, int index, int[] expectedArray)
        {
            DoubleLinkedList additionalList = new DoubleLinkedList(additionalArray);
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);

            actual.AddListByIndex(additionalList, index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2 }, 5)]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2 }, -4)]
        public void AddListByIndex_WhenIndexOutOfRange_IndexOutOfRangeException(int[] inputArray, int[] additionalArray, int index)
        {
            DoubleLinkedList additionalList = new DoubleLinkedList(additionalArray);
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);
            try
            {
                actual.AddListByIndex(additionalList, index);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 0)]
        public void AddListByIndex_WhenArgumentIsNull_NullReferenceException(int[] inputArray, int index)
        {
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);
            try
            {
                actual.AddListByIndex(null, index);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 100, 99, 88, 77, 5, 4, 3, 2, 1, 100, 200 })]
        public void AllMethodsTest(int[] inputArray, int[] expectedArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(inputArray);
            actual.Add(8);
            actual.AddAtFirstIndex(100);
            actual.AddAtIndex(20, 3);
            actual.Remove();
            actual.RemoveAtFirstIndex();
            actual.RemoveByIndex(1);
            actual.Add(9);
            actual.RemoveLastValues(3);
            actual.AddAtFirstIndex(100);
            actual.AddAtFirstIndex(25);
            actual.RemoveFirstValues(2);
            actual.AddListByIndex(new DoubleLinkedList(new int[] { 2, 3, 4, 5 }), 1);
            actual.RemoveValuesByIndex(5, 2);
            actual.Reverse();
            actual.SortAscending();
            actual.SortDescending();
            actual.AddList(new DoubleLinkedList(new int[] { 100, 200 }));
            actual.AddListAtBeginning(new DoubleLinkedList(new int[] { 99, 88, 77 }));
            actual.AddAtFirstIndex(100);
            Assert.AreEqual(expected, actual);
        }
    }
}
