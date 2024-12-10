using System.IO;
using Tyuiu.BabaiKV.Sprint6.Task6.V15.Lib;
namespace Tyuiu.BabaiKV.Sprint6.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = "C:\\DataSprint6\\InPutDataFileTask6V15.txt";
            string str = ds.CollectTextFromFile(path);
            string wait = "HlidZPHKeLLUOoyPFhjSRwpGUilXwwiukCfOUaZNpcgYjw";
            Assert.AreEqual(wait, str);
        }
    }
}