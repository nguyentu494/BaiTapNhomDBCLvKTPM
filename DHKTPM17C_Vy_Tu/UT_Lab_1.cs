using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Principal;

namespace DHKTPM17C_Vy_Tu
{
    [TestClass]
    public class UT_Lab_1
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\UT_Lab_1.csv", "UT_Lab_1#csv", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int inputA = Convert.ToInt32(TestContext.DataRow["a"]);
            int inputB = Convert.ToInt32(TestContext.DataRow["b"]);
            int inputC = Convert.ToInt32(TestContext.DataRow["c"]);
            String expectedRst = Convert.ToString(TestContext.DataRow["rst"]);
            if (!expectedRst.Equals("exception"))
            {
                int expected = int.Parse(expectedRst);
                int result = methodLibrary.Max(inputA, inputB, inputC);
                Assert.AreEqual(expected, result);
            }
            else
            {
                Exception expectedException = null;
                try
                {
                    methodLibrary.Max(inputA,inputB, inputC);
                }
                catch (Exception ex)
                {
                    // Catches the exception
                    expectedException = ex;
                }
                
                Assert.IsNotNull(expectedException);
            }


        }
    }
}
