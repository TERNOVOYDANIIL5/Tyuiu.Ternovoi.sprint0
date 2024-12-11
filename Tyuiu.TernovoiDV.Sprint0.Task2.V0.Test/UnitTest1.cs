using Tyuiu.SychevAD.Sprint0.Task2.V0.Lib;
namespace Tyuiu.SychevAD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Ñàøà";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Ïðèâåò, Ñàøà", res);
        }
    }
}
}   