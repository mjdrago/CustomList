using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreateListClass;

namespace CreateListClassTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void AddTest_AddAnInt5ToDefaultArray_Int5AtIndex0()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>();
            //Act
            testCreation.Add(5);
            //Assert
            Assert.AreEqual(5, testCreation[0]);
        }
        [TestMethod]
        public void AddTest_AddAnInt5ToDefaultArray_Count1()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>();
            //Act
            testCreation.Add(5);
            //Assert
            Assert.AreEqual(1, testCreation.Count);
        }
        [TestMethod]
        public void AddTest_AddAnInt5ToDefaultArray_Capacity4()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>();
            //Act
            testCreation.Add(5);
            //Assert
            Assert.AreEqual(4, testCreation.Capacity);
        }
        [TestMethod]
        public void AddTest_AddAStringHelloToDefaultArray_StringHelloAtIndex0()
        {
            //Arrange
            CustomList<string> testCreation = new CustomList<string>();
            //Act
            testCreation.Add("Hello");
            //Assert
            Assert.AreEqual("Hello", testCreation[0]);
        }
        [TestMethod]
        public void AddTest_AddAStringHelloToDefaultArray_Count1()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>();
            //Act
            testCreation.Add(5);
            //Assert
            Assert.AreEqual(1, testCreation.Count);
        }
        [TestMethod]
        public void AddTest_AddAStringHelloToDefaultArray_Capacity4()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>();
            //Act
            testCreation.Add(5);
            //Assert
            Assert.AreEqual(4, testCreation.Capacity);
        }

        [TestMethod]
        public void AddTest_Add3IntsToSizedArray_Count3()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>(4);
            //Act
            testCreation.Add(4);
            testCreation.Add(7);
            testCreation.Add(1);
            //Assert
            Assert.AreEqual(3, testCreation.Count);
        }
        [TestMethod]
        public void AddTest_AddMultiple3IntsToSizedArray_Capacity4()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>(4);
            //Act
            testCreation.Add(4);
            testCreation.Add(7);
            testCreation.Add(1);
            //Assert
            Assert.AreEqual(4, testCreation.Capacity);
        }
        [TestMethod]
        public void AddTest_AddMultiple3IntsToSizedArray_Int7AtIndex1()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>(4);
            //Act
            testCreation.Add(4);
            testCreation.Add(7);
            testCreation.Add(1);
            //Assert
            Assert.AreEqual(7, testCreation[1]);
        }
        [TestMethod]
        public void AddTest_AddMultiple3IntsToSizedArray_Int1AtIndex2()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>(4);
            //Act
            testCreation.Add(4);
            testCreation.Add(7);
            testCreation.Add(1);
            //Assert
            Assert.AreEqual(1, testCreation[2]);
        }
        [TestMethod]
        public void AddTest_AddMultiple4IntsToSizedArray_Capacity4()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>(4);
            //Act
            testCreation.Add(4);
            testCreation.Add(7);
            testCreation.Add(1);
            testCreation.Add(10);
            //Assert
            Assert.AreEqual(4, testCreation.Capacity);
        }
        [TestMethod]
        public void AddTest_AddMultiple4IntsToSizedArray_Count4()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>(4);
            //Act
            testCreation.Add(4);
            testCreation.Add(7);
            testCreation.Add(1);
            testCreation.Add(10);
            //Assert
            Assert.AreEqual(4, testCreation.Count);
        }
        [TestMethod]
        public void AddTest_AddMultiple4IntsToSizedArray_Capacity8()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>(4);
            //Act
            testCreation.Add(4);
            testCreation.Add(7);
            testCreation.Add(1);
            testCreation.Add(10);
            testCreation.Add(3);
            //Assert
            Assert.AreEqual(8, testCreation.Capacity);
        }
        [TestMethod]
        public void AddTest_AddMultiple4IntsToSizedArray_Count5()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>(4);
            //Act
            testCreation.Add(4);
            testCreation.Add(7);
            testCreation.Add(1);
            testCreation.Add(10);
            testCreation.Add(3);
            //Assert
            Assert.AreEqual(5, testCreation.Count);
        }
        [TestMethod]
        public void AddTest_AddValuesToAFilledArray_Int8AtIndex3()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>(){5,4,3} ;
            //Act
            testCreation.Add(8);
            //Assert
            Assert.AreEqual(8, testCreation[3]);
        }
        [TestMethod]
        public void RemoveTest_RemoveLastElementFromListWith4UniqueIntValues_Count3()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>() { 1, 2, 3, 4 };
            //Act
            testCreation.Remove(4);
            //Assert
            Assert.AreEqual(3, testCreation.Count);
        }
        [TestMethod]
        public void RemoveTest_RemoveLastElementFromListWith4UniqueIntValues_Capacity4()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>() { 1, 2, 3, 4 };
            //Act
            testCreation.Remove(4);
            //Assert
            Assert.AreEqual(4, testCreation.Capacity);
        }
        [TestMethod]
        public void RemoveTest_RemoveLastElementFromListWith4UniqueIntValues_LastIndexHas3()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>() { 1, 2, 3, 4 };
            //Act
            testCreation.Remove(4);
            //Assert
            Assert.AreEqual(3, testCreation[testCreation.Count - 1]);
        }
        [TestMethod]
        public void RemoveTest_RemoveLastElementFromListWith4UniqueStringValues_Count3()
        {
            //Arrange
            CustomList<string> testCreation = new CustomList<string>() { "Hello", "world", "how", "are" };
            //Act
            testCreation.Remove("are");
            //Assert
            Assert.AreEqual(3, testCreation.Count);
        }
        [TestMethod]
        public void RemoveTest_RemoveLastElementFromListWith4UniqueStringValues_Capacity4()
        {
            //Arrange
            CustomList<string> testCreation = new CustomList<string>() { "Hello", "world", "how", "are" };
            //Act
            testCreation.Remove("are");
            //Assert
            Assert.AreEqual(4, testCreation.Capacity);
        }
        [TestMethod]
        public void RemoveTest_RemoveLastElementFromListWith4UniqueStringValues_LastIndexHasHow()
        {
            //Arrange
            CustomList<string> testCreation = new CustomList<string>() { "Hello", "world", "how", "are" };
            //Act
            testCreation.Remove("are");
            //Assert
            Assert.AreEqual("how", testCreation[testCreation.Count - 1]);
        }
    }
}
