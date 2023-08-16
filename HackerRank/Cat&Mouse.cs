using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    static void Main(string[] args)
    {
        //questions.catAndMouse(args);
        questions.mirror(args);
    }
}
class questions
{
    #region  Cats & Mouse
    static string catAndMouseWorker(int a, int b, int m)
        {
            StringBuilder sb = new StringBuilder();

            int da = m - a >= 0 ? m - a : a - m;
            int db = m - b >= 0 ? m - b : b - m;

            if (da < db)
            {
                sb.Append("Cat A");
            }
            else if (db < da)
            {
                sb.Append("Cat B");
            }
            else
            {
                {
                    sb.Append("Mouse C");
                }
            }
            return sb.ToString();
        }

        public static void catAndMouse(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouseWorker(x, y, z);

                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    #endregion
    #region mirror
    public static void mirror(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        int[] ordered = new int[arr.Count()];
        for (int i = 0; i < arr.Count(); i++)
        {
            ordered[i] = arr[arr.Count - 1 - i];
        }
        StringBuilder sb = new StringBuilder();
        foreach (int i in ordered)
        {
            sb.Append(i);
            sb.Append(" ");
        }

        Console.WriteLine(sb.ToString());
    }
    #endregion
}
