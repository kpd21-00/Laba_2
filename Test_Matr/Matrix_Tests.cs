using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matr_Lab;

namespace Test_Matr
{
    [TestClass]
    public class Matrix_Tests
    {
        [TestMethod]
        public void Index()
        {
            //arrange
            Matr_lab<int> a = new Matr_lab<int>(5);
            a[1, 2] = 100;
            int expected = 100;

            //act
            int actual = a[1, 2];

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sum_Matr_2_2()
        {
            //arrange
            Matr_lab<int> a = new Matr_lab<int>(2);
            Matr_lab<int> b = new Matr_lab<int>(2);
            Matr_lab<int> expected;
            Matr_lab<int> actual = new Matr_lab<int>(2);
            

            //act
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    a[i, j] = 1;
                    b[i, j] = 1;
                    actual[i, j] = 2;
                }
            expected = a + b;

            //assert
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
        }
        [TestMethod]
        public void Mult_Matr_2_2()
        {
            //arrange
            Matr_lab<int> a = new Matr_lab<int>(2);
            Matr_lab<int> b = new Matr_lab<int>(2);
            Matr_lab<int> expected;
            Matr_lab<int> actual = new Matr_lab<int>(2);

            //act
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    a[i, j] = 1;
                    b[i, j] = 1;
                    actual[i, j] = 2;
                }
            expected = a * b;

            //assert
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Negative_Type()
        {
            //arrange
            Matr_lab<string> a = new Matr_lab<string>(5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Negarive_mis()
        {
            Matr_lab<int> a = new Matr_lab<int>(-2);
        }
        [TestMethod]
        public void Random_2_2()
        {
            //arrange
            Matr_lab<int> actual = new Matr_lab<int>(2);
            Matr_lab<int> expected = new Matr_lab<int>(2);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    expected[i, j] = i + j;

            //act
            actual.Rand((x, y) => x + y);

            //assert
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
        }
    }
}
