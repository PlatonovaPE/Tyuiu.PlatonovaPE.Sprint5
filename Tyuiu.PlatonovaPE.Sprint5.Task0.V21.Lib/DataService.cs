﻿using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PlatonovaPE.Sprint5.Task0.V21.Lib
{
    public class DataService : ISprint5Task0V21
    {
        public string SaveToFileTextData(int x)
        {
            double z = Math.Round((Math.Pow(x, 2) + 1) / Math.Sqrt(4 * Math.Pow(x, 2) - 3), 3);
            z = Math.Round(z, 3);
            string tempFilePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            using (StreamWriter writer = File.CreateText(tempFilePath))
            {
                writer.WriteLine(z);
            }
            return z.ToString();
        }
    }
}