using Tyuiu.PlatonovaPE.Sprint5.Task6.V18.Lib;
namespace Tyuiu.PlatonovaPE.Sprint5.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFileValid()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask6.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool Exists = fileInfo.Exists;
            Assert.IsTrue(Exists);
        }
    }
}