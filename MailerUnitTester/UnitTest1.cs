using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mailer;

namespace MailerUnitTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumTestInt()
        {
            int result = Mailer.Model.Calculation.Sum(2, 2);
            int expected = 4;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SumTestDouble()
        {
            double result = Mailer.Model.Calculation.Sum(0.1, 0.1);
            double expected = 0.2;
            Assert.AreEqual(expected, result,0.01);
        }

        [TestMethod]
        public void SumTestString()
        {
            string result = Mailer.Model.Calculation.Sum("1","1");
            string expected = "11";
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void SumTestStringForException()
        {
            try
            {
                string result = Mailer.Model.Calculation.Sum("1","2");
                
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("Test OK");
            }
        }

    }
}
