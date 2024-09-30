using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM17C_Vy_Tu
{
    [TestClass]
    public class UT_Lab_2
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            float x1, x2;
            String expected = "Vô số nghiệm";
            String actual = methodLibrary.SolveQuadratic(0, 0, 0, out x1, out x2);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(float.NaN, x1);
            Assert.AreEqual(float.NaN, x2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            float x1, x2;
            String expected = "Vô nghiệm";
            String actual = methodLibrary.SolveQuadratic(0, 0, -5, out x1, out x2);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(float.NaN, x1);
            Assert.AreEqual(float.NaN, x2);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            float x1, x2;
            String expected = "Vô nghiệm";
            String actual = methodLibrary.SolveQuadratic(1, 1, 1, out x1, out x2);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(float.NaN, x1);
            Assert.AreEqual(float.NaN, x2);
        }

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            float x1, x2;
            String expected = "Có 2 nghiệm phân biệt";
            String actual = methodLibrary.SolveQuadratic(1, -3, 2, out x1, out x2);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(1, x1);
            Assert.AreEqual(2, x2);
        }

        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            float x1, x2;
            String expected = "Có nghiệm kép";
            String actual = methodLibrary.SolveQuadratic(1, -4, 4, out x1, out x2);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(2, x1);
            Assert.AreEqual(2, x2);
        }

        [TestMethod]
        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            float x1, x2;
            String expected = "Có 1 nghiệm";
            String actual = methodLibrary.SolveQuadratic(0, 5, -10, out x1, out x2);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(2, x1);
            Assert.AreEqual(2, x2);
        }
    }
}
