using Tyuiu.PlatonovaPE.Sprint5.Task3.V28.Lib;

namespace Tyuiu.PlatonovaPE.Sprint5.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckecExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\parse\source\repos\Tyuiu.PlatonovaPE.Sprint5\Tyuiu.PlatonovaPE.Sprint5.Task3.V28\bin\Debug\net8.0\OutPutFileTask3";

            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }
    }
}