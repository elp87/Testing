using elp87.MyMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyMath.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestProduct()
        {
            // Ожидаемое значение
            int expValue = 8;

            Math test = new Math();
            int value = test.Product(5, 3);

            // Сравнение результатов
            Assert.AreEqual(expValue, value);
        }
    }
}
