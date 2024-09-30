using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM17C_Vy_Tu
{
    [TestClass]
    public class UT_Lab_4
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\UT_Lab_4.csv", "UT_Lab_4#csv", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int s0 = Convert.ToInt32(TestContext.DataRow["s0"]);
            long s;

            long kExpected = Convert.ToInt64(TestContext.DataRow["k"]);
            long kActual = methodLibrary.Sum(s0,out s);

            long sExpected = Convert.ToInt64(TestContext.DataRow["s"]);
            long sActual = s;

            Assert.AreEqual(sExpected, sActual);
            Assert.AreEqual(kExpected, kActual);

        }
    }
}
