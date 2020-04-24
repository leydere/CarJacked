using System;
using System.Collections.Generic;
using System.IO;

namespace CarJack
{
    public class GarageFunctions
    {
        public static bool CheckIfFree(int x)
        {
            bool isFree = false;
            string test;

            //Set up readable files
            string v1txtPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\CarJack\\vehicle_profiles\\vehicle1.txt";
            string v2txtPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\CarJack\\vehicle_profiles\\vehicle2.txt";
            string v3txtPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\CarJack\\vehicle_profiles\\vehicle3.txt";
            switch (x)
            {
                case 1:

                    var carLogFile_1 = new List<string>(File.ReadAllLines(v1txtPath));
                    try
                    {
                        test = carLogFile_1[0];
                    }
                    catch
                    {
                        isFree = true;
                        return isFree;
                    }

                    if (test == "")
                    {
                        isFree = true;

                    }
                    else
                    {
                        isFree = false;
                    }
                    break;
                case 2:
                    var carLogFile_2 = new List<string>(File.ReadAllLines(v2txtPath));
                    try
                    {
                        test = carLogFile_2[0];
                    }
                    catch
                    {
                        isFree = true;
                        return isFree;
                    }
                    if (test == "")
                    {
                        isFree = true;

                    }
                    else
                    {
                        isFree = false;
                    }
                    break;

                case 3:
                    var carLogFile_3 = new List<string>(File.ReadAllLines(v3txtPath));
                    try
                    {
                        test = carLogFile_3[0];
                    }
                    catch
                    {
                        isFree = true;

                        return isFree;
                    }

                    if (test == "")
                    {
                        isFree = true;

                    }
                    else
                    {
                        isFree = false;
                    }

                    return isFree;
            }
            return isFree;
        }
    }
}
