using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.PlatonovaPE.Sprint5.Task4.V18.Lib;

namespace Tyuiu.PlatonovaPE.Sprint5.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromDataFile()
        {
            string path = @"C:\Users\parse\source\repos\Tyuiu.PlatonovaPE.Sprint5\Tyuiu.PlatonovaPE.Sprint5.Task4.V18\bin\Debug\net8.0\OutPutFileTask4";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}