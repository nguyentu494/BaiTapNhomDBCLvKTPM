using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM17C_Vy_Tu
{
    [TestClass]
    public class UT_Lab_6
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\UT_Lab_6.csv", "UT_Lab_6#csv", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            String s1 = Convert.ToString(TestContext.DataRow["s1"]);
            String s2 = Convert.ToString(TestContext.DataRow["s2"]);
            String s3 = Convert.ToString(TestContext.DataRow["s3"]);

            String expected = Convert.ToString(TestContext.DataRow["result"]);
            String actual = methodLibrary.ThayThe(s1, s2, s3);

            Assert.AreEqual(expected, actual);

        }
    }
}
