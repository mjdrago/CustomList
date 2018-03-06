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
        public void AddTest_AddAnInt5ToDefaultArray_Capacity5()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>();
            //Act
            testCreation.Add(5);
            //Assert
            Assert.AreEqual(5, testCreation.Capacity);
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
        public void AddTest_AddAStringHelloToDefaultArray_Capacity5()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>();
            //Act
            testCreation.Add(5);
            //Assert
            Assert.AreEqual(5, testCreation.Capacity);
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
        public void AddTest_AddMultiple3IntsToSizedArray_Capacity8()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>(4);
            //Act
            testCreation.Add(4);
            testCreation.Add(7);
            testCreation.Add(1);
            //Assert
            Assert.AreEqual(8, testCreation.Capacity);
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
        public void AddTest_AddMultiple4IntsToSizedArray_Capacity8()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>(4);
            //Act
            testCreation.Add(4);
            testCreation.Add(7);
            testCreation.Add(1);
            testCreation.Add(10);
            //Assert
            Assert.AreEqual(8, testCreation.Capacity);
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
        public void AddTest_AddMultiple4IntsToSizedArray_Capacity16()
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
            Assert.AreEqual(16, testCreation.Capacity);
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
        public void RemoveTest_RemoveLastElementFromListWith4UniqueIntValues_Capacity10()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>() { 1, 2, 3, 4 };
            //Act
            testCreation.Remove(4);
            //Assert
            Assert.AreEqual(10, testCreation.Capacity);
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
        public void RemoveTest_RemoveLastElementFromListWith4UniqueIntValues_ReturnTrue()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>() { 1, 2, 3, 4 };
            //Act
            bool check = testCreation.Remove(4);
            //Assert
            Assert.AreEqual(true, check);
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
        public void RemoveTest_RemoveLastElementFromListWith4UniqueStringValues_Capacity10()
        {
            //Arrange
            CustomList<string> testCreation = new CustomList<string>() { "Hello", "world", "how", "are" };
            //Act
            testCreation.Remove("are");
            //Assert
            Assert.AreEqual(10, testCreation.Capacity);
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
        [TestMethod]
        public void RemoveTest_RemoveValue8FromIndex2ofUniqueValuedArray_ValueAtIndex2Is5()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>() { 3, 1, 8, 5 };
            //Act
            testCreation.Remove(8);
            //Assert
            Assert.AreEqual(5, testCreation[2]);
        }
        [TestMethod]
        public void RemoveTest_RemoveValue8FromIndex2ofUniqueValuedArray_Count3()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>() { 3, 1, 8, 5 };
            //Act
            testCreation.Remove(8);
            //Assert
            Assert.AreEqual(3, testCreation.Count);
        }

        [TestMethod]
        public void RemoveTest_TryToRemoveAnValueNotInArray_Count4()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>() { 3, 1, 8, 5 };
            //Act
            testCreation.Remove(10);
            //Assert
            Assert.AreEqual(4, testCreation.Count);
        }

        [TestMethod]
        public void RemoveTest_TryToRemoveAnValueNotInArray_ReturnsFalse()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>() { 3, 1, 8, 5 };
            //Act
            bool check = testCreation.Remove(10);
            //Assert
            Assert.AreEqual(false, check);
        }

        [TestMethod]
        public void Iteration_StringFields_ReturnsText()
        {
            //Arrange
            CustomList<string> testCreation = new CustomList<string>() { "Hello", "World", "Boo", "You" };
            //Act
            string phrase = "";
            foreach (var word in testCreation)
            {
                phrase = phrase + word;
            }
            //Assert
            Assert.AreEqual("HelloWorldBooYou", phrase);
        }

        [TestMethod]
        public void Iteration_IntFields_ReturnsSum()
        {
            //Arrange
            CustomList<int> testCreation = new CustomList<int>() { 15, 5, 10, 15};
            //Act
            int sum = 0;
            foreach (var number in testCreation)
            {
                sum += number;
            }
            //Assert
            Assert.AreEqual(45, sum);
        }

        [TestMethod]
        public void ToString_DefaultInitation_StringWithNameAndHowFilled()
        {
            //Arrange
            CustomList<string> testCreation = new CustomList<string>();
            //Act
            string output = testCreation.ToString();
            //Assert
            Assert.AreEqual("0/5 Spots Filled\n", output);
        }
        [TestMethod]
        public void ToString_SetCapacityInitation_StringWithNameAndHowFilled()
        {
            //Arrange
            CustomList<string> testCreation = new CustomList<string>(15);
            //Act
            string output = testCreation.ToString();
            //Assert
            Assert.AreEqual("0/15 Spots Filled\n", output);
        }
        [TestMethod]
        public void ToString_WithInitialValuesInitation_StringWithNameAndHowFilled()
        {
            //Arrange
            CustomList<string> testCreation = new CustomList<string>() {"hello","you","are" };
            //Act
            string output = testCreation.ToString();
            //Assert
            Assert.AreEqual("3/10 Spots Filled\nIndex 0: hello\nIndex 1: you\nIndex 2: are\n", output);
        }
        [TestMethod]
        public void OverloadedPlusSign_CombineTwoSameSizedArrays_Count6()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 1, 4, 6 };
            CustomList<int> testCreation2 = new CustomList<int>() { 2, 3, 9 };
            //Act
            CustomList<int> output = testCreation1 + testCreation2;
            //Assert
            Assert.AreEqual(6, output.Count);
        }
        [TestMethod]
        public void OverloadedPlusSign_CombineTwoSameSizedArrays_Capacity20()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 1, 4, 6 };
            CustomList<int> testCreation2 = new CustomList<int>() { 2, 3, 9 };
            //Act
            CustomList<int> output = testCreation1 + testCreation2;
            //Assert
            Assert.AreEqual(20, output.Capacity);
        }
        [TestMethod]
        public void OverloadedPlusSign_CombineTwoSameSizedArrays_9AtFinalIndex()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 1, 4, 6 };
            CustomList<int> testCreation2 = new CustomList<int>() { 2, 3, 9 };
            //Act
            CustomList<int> output = testCreation1 + testCreation2;
            //Assert
            Assert.AreEqual(9, output[output.Count -1]);
        }
        [TestMethod]
        public void OverloadedPlusSign_CombineTwoDifferentSizedArrays_Count7()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 1, 4, 6 };
            CustomList<int> testCreation2 = new CustomList<int>() { 2, 3, 9,7 };
            //Act
            CustomList<int> output = testCreation1 + testCreation2;
            //Assert
            Assert.AreEqual(7, output.Count);
        }
        [TestMethod]
        public void OverloadedPlusSign_CombineTwoDifferentSizedArrays_Capacity20()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 1, 4, 6 };
            CustomList<int> testCreation2 = new CustomList<int>() { 2, 3, 9,7 };
            //Act
            CustomList<int> output = testCreation1 + testCreation2;
            //Assert
            Assert.AreEqual(20, output.Capacity);
        }
        [TestMethod]
        public void OverloadedPlusSign_CombineTwoDifferentSizedArrays_7AtFinalIndex()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 1, 4, 6 };
            CustomList<int> testCreation2 = new CustomList<int>() { 2, 3, 9,7 };
            //Act
            CustomList<int> output = testCreation1 + testCreation2;
            //Assert
            Assert.AreEqual(7, output[output.Count - 1]);
        }
        [TestMethod]
        public void Zip_ZippingTwoEqualSizedArrays_Count6()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> testCreation2 = new CustomList<int>() { 2, 4, 6 };
            //Act
            CustomList<int> output = testCreation1.Zip(testCreation2);
            //Assert
            Assert.AreEqual(6, output.Count);
        }

        [TestMethod]
        public void Zip_ZippingTwoEqualSizedArrays_Capacity20()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> testCreation2 = new CustomList<int>() { 2, 4, 6 };
            //Act
            CustomList<int> output = testCreation1.Zip(testCreation2);
            //Assert
            Assert.AreEqual(20, output.Capacity);
        }

        [TestMethod]
        public void Zip_ZippingTwoEqualSizedArrays_Index2Has3()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> testCreation2 = new CustomList<int>() { 2, 4, 6 };
            //Act
            CustomList<int> output = testCreation1.Zip(testCreation2);
            //Assert
            Assert.AreEqual(3, output[2]);
        }
        [TestMethod]
        public void Zip_ZippingTwoEqualSizedArrays_LastIndexHas6()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> testCreation2 = new CustomList<int>() { 2, 4, 6 };
            //Act
            CustomList<int> output = testCreation1.Zip(testCreation2);
            //Assert
            Assert.AreEqual(6, output[output.Count -1]);
        }
        [TestMethod]
        public void Zip_ZippingTwoUnEqualSizedArraysFirstBigger_Count8()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 1, 3, 5, 7, 9 };
            CustomList<int> testCreation2 = new CustomList<int>() { 2, 4, 6 };
            //Act
            CustomList<int> output = testCreation1.Zip(testCreation2);
            //Assert
            Assert.AreEqual(8, output.Count);
        }
        [TestMethod]
        public void Zip_ZippingTwoUnEqualSizedArraysFirstBigger_Capacity20()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 1, 3, 5, 7, 9 };
            CustomList<int> testCreation2 = new CustomList<int>() { 2, 4, 6 };
            //Act
            CustomList<int> output = testCreation1.Zip(testCreation2);
            //Assert
            Assert.AreEqual(20, output.Capacity);
        }
        [TestMethod]
        public void Zip_ZippingTwoUnEqualSizedArraysFirstBigger_LastIndexHas9()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 1, 3, 5, 7, 9 };
            CustomList<int> testCreation2 = new CustomList<int>() { 2, 4, 6 };
            //Act
            CustomList<int> output = testCreation1.Zip(testCreation2);
            //Assert
            Assert.AreEqual(9, output[output.Count -1]);
        }
        [TestMethod]
        public void Zip_ZippingTwoUnEqualSizedArraysFirstBigger_2ndToLastIndexHas7()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 1, 3, 5, 7, 9 };
            CustomList<int> testCreation2 = new CustomList<int>() { 2, 4, 6 };
            //Act
            CustomList<int> output = testCreation1.Zip(testCreation2);
            //Assert
            Assert.AreEqual(7, output[output.Count - 2]);
        }
        [TestMethod]
        public void Zip_ZippingTwoUnEqualSizedArraysFirstBigger_3rdToLastIndexHas6()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 1, 3, 5, 7, 9 };
            CustomList<int> testCreation2 = new CustomList<int>() { 2, 4, 6 };
            //Act
            CustomList<int> output = testCreation1.Zip(testCreation2);
            //Assert
            Assert.AreEqual(6, output[output.Count - 3]);
        }

        [TestMethod]
        public void Zip_ZippingTwoUnEqualSizedArraysSecondBigger_Count8()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 1, 3, 5};
            CustomList<int> testCreation2 = new CustomList<int>() { 2, 4, 6, 8, 10 };
            //Act
            CustomList<int> output = testCreation1.Zip(testCreation2);
            //Assert
            Assert.AreEqual(8, output.Count);
        }
        [TestMethod]
        public void Zip_ZippingTwoUnEqualSizedArraysSecondBigger_Capacity20()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> testCreation2 = new CustomList<int>() { 2, 4, 6, 8, 10 };
            //Act
            CustomList<int> output = testCreation1.Zip(testCreation2);
            //Assert
            Assert.AreEqual(20, output.Capacity);
        }
        [TestMethod]
        public void Zip_ZippingTwoUnEqualSizedArraysSecondBigger_LastIndexHas9()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> testCreation2 = new CustomList<int>() { 2, 4, 6, 8, 10 };
            //Act
            CustomList<int> output = testCreation1.Zip(testCreation2);
            //Assert
            Assert.AreEqual(10, output[output.Count - 1]);
        }
        [TestMethod]
        public void Zip_ZippingTwoUnEqualSizedArraysSecondBigger_2ndToLastIndexHas7()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> testCreation2 = new CustomList<int>() { 2, 4, 6, 8, 10 };
            //Act
            CustomList<int> output = testCreation1.Zip(testCreation2);
            //Assert
            Assert.AreEqual(8, output[output.Count - 2]);
        }
        [TestMethod]
        public void Zip_ZippingTwoUnEqualSizedArraysSecondBigger_4thToLastIndexHas6()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> testCreation2 = new CustomList<int>() { 2, 4, 6, 8, 10 };
            //Act
            CustomList<int> output = testCreation1.Zip(testCreation2);
            //Assert
            Assert.AreEqual(5, output[output.Count - 4]);
        }
        [TestMethod]
        public void OverloadingMinusSign_SubtractingASmallerArrayFromBiggerArray_Count3()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 5, 8, 7, 15, 21, 10 };
            CustomList<int> testCreation2 = new CustomList<int>() { 15, 21, 10 };
            //Act
            CustomList<int> result = testCreation1 - testCreation2;
            //Assert
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void OverloadingMinusSign_SubtractingASmallerArrayFromBiggerArray_Capacity20()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 5, 8, 7, 15, 21, 10 };
            CustomList<int> testCreation2 = new CustomList<int>() { 15, 21, 10 };
            //Act
            CustomList<int> result = testCreation1 - testCreation2;
            //Assert
            Assert.AreEqual(20, result.Capacity);
        }

        [TestMethod]
        public void OverloadingMinusSign_SubtractingASmallerArrayFromBiggerArray_LastIndex7()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 5, 8, 7, 15, 21, 10 };
            CustomList<int> testCreation2 = new CustomList<int>() { 15, 21, 10 };
            //Act
            CustomList<int> result = testCreation1 - testCreation2;
            //Assert
            Assert.AreEqual(7, result[result.Count - 1]);
        }

        [TestMethod]
        public void OverloadingMinusSign_SubtractingASmallerArrayFromBiggerArrayWithDoubles_Count4()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 5, 8, 15, 7, 15, 21, 10 };
            CustomList<int> testCreation2 = new CustomList<int>() { 15, 21, 10 };
            //Act
            CustomList<int> result = testCreation1 - testCreation2;
            //Assert
            Assert.AreEqual(4, result.Count);
        }

        [TestMethod]
        public void OverloadingMinusSign_SubtractingASmallerArrayFromBiggerArrayWithDoubles_Capacity20()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 5, 8, 15, 7, 15, 21, 10 };
            CustomList<int> testCreation2 = new CustomList<int>() { 15, 21, 10 };
            //Act
            CustomList<int> result = testCreation1 - testCreation2;
            //Assert
            Assert.AreEqual(20, result.Capacity);
        }


        [TestMethod]
        public void OverloadingMinusSign_SubtractingASmallerArrayFromBiggerArrayWithDoubles_Value15AtIndex2()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 5, 8, 15, 7, 15, 21, 10 };
            CustomList<int> testCreation2 = new CustomList<int>() { 15, 21, 10 };
            //Act
            CustomList<int> result = testCreation1 - testCreation2;
            //Assert
            Assert.AreEqual(15, result[2]);
        }
        [TestMethod]
        public void OverloadingMinusSign_SubtractingASmallerArrayNotInBiggerArrayWithDoubles_Count7()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 5, 8, 15, 7, 15, 21, 10 };
            CustomList<int> testCreation2 = new CustomList<int>() { 5, 15, 10 };
            //Act
            CustomList<int> result = testCreation1 - testCreation2;
            //Assert
            Assert.AreEqual(7, result.Count);
        }

        [TestMethod]
        public void OverloadingMinusSign_SubtractingASmallerArrayNotInBiggerArrayWithDoubles_Capacity20()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 5, 8, 15, 7, 15, 21, 10 };
            CustomList<int> testCreation2 = new CustomList<int>() { 5, 15, 10 };
            //Act
            CustomList<int> result = testCreation1 - testCreation2;
            //Assert
            Assert.AreEqual(20, result.Capacity);
        }


        [TestMethod]
        public void OverloadingMinusSign_SubtractingASmallerArrayNotInBiggerArrayWithDoubles_Value15AtIndex2()
        {
            //Arrange
            CustomList<int> testCreation1 = new CustomList<int>() { 5, 8, 15, 7, 15, 21, 10 };
            CustomList<int> testCreation2 = new CustomList<int>() { 5, 15, 10 };
            //Act
            CustomList<int> result = testCreation1 - testCreation2;
            //Assert
            Assert.AreEqual(10, result[result.Count - 1]);
        }
    }
}
