﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PlatonovaPE.Sprint5.Task1.V24.Lib
{
    public class DataService : ISprint5Task1V24
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            //stopValue++;

            string ans = "";

            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });

            FileInfo f = new FileInfo(path);
            if (f.Exists)
            {
                File.Delete(path);
            }

            double temp;

            for (int i = startValue; i < stopValue; i++)
            {
                temp = 4 * i - 0.5;
                if (temp == 0)
                {
                    ans += "0" + "\r\n";
                    continue;
                }
                ans += Math.Round(3 * Math.Cos(i) / temp + Math.Sin(i) - 5 * i - 2, 2) + "\n";
            }

            temp = 4 * stopValue - 0.5;
            if (temp == 0)
            {
                ans += "0";
                goto RET;
            }
            ans += Math.Round(3 * Math.Cos(stopValue) / temp + Math.Sin(stopValue) - 5 * stopValue - 2, 2);


        RET:
            File.WriteAllText(path, ans);
            /*
            temp = 4 * stopValue - 0.5;

            if (temp == 0)
            {
                File.AppendAllText(path, "0");

                return path;
            }

            File.AppendAllText(path, Math.Round(3 * Math.Cos(stopValue) / temp + Math.Sin(stopValue) - 5 * stopValue - 2, 2) + "");*/

            return path;
        }
    }
}