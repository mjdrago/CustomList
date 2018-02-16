using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreateListClass;

namespace CreateListClassTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void AddTest_AddAnInt5ToArray_Int5AtIndex0()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>();
            //Act
            testCreation.Add(5);
            //Assert
            Assert.AreEqual(5, testCreation[0]);
        }
        [TestMethod]
        public void AddTest_AddAnInt5ToArray_Count1()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>();
            //Act
            testCreation.Add(5);
            //Assert
            Assert.AreEqual(1, testCreation.Count);
        }
        [TestMethod]
        public void AddTest_AddAnInt5ToArray_Capacity3()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>();
            //Act
            testCreation.Add(5);
            //Assert
            Assert.AreEqual(1, testCreation.Capacity);
        }
    }
}
