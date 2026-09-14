using Tyuiu.ErmolaevEO.Sprint1.Task0.V22.Lib;
namespace Tyuiu.ErmolaevEO.Sprint1.Task0.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService sd = new DataService();
            var res = sd.Calculate();
            Assert.AreEqual(10, res);
        }
    }
}
