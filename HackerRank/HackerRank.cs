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
        //Person.starter(args);
        //questions.catAndMouse(args);
        //evenodddivider.starter(args);
        //recordbreaker.starter(args);
        //BetweenTwoSets.starter(args);
        //AppleandOrange.starter(args);
        NumberLineJumps.starter(args);
        //GradingStudents.starter(args);
        //questions.mirror(args);
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
class Person
{
    public int age;
    public Person(int initialAge)
    {
        if (initialAge < 0)
        {
            Console.WriteLine("Age is not valid, setting age to 0.");
            age = 0;
        }
        else age = initialAge;
    }
    public void amIOld()
    {
        // Do some computations in here and print out the correct statement to the console 
        if (age < 13)
        {
            Console.WriteLine("You are young.");
        }
        else if (age >= 13 && age < 18)
        {
            Console.WriteLine("You are a teenager.");
        }
        else if (age >= 18)
        {
            Console.WriteLine("You are old.");
        }
    }

    public void yearPasses()
    {
        // Increment the age of the person in here
        age = age + 1;
    }

    public static void starter(String[] args)
    {
        int T = int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++)
        {
            int age = int.Parse(Console.In.ReadLine());
            Person p = new Person(age);
            p.amIOld();
            for (int j = 0; j < 3; j++)
            {
                p.yearPasses();
            }
            p.amIOld();
            Console.WriteLine();
        }
    }
}
class evenodddivider
{
    public static void starter(String[] args)
    {

        int size = int.Parse(Console.ReadLine());
        List<string> words = new List<string>();
        for (int i = 0; i < size; i++)
        {
            words.Add(Console.ReadLine().ToString().TrimEnd());
        }
        foreach (string word in words)
        {
            Printer(word);
        }
    }
    private static void Printer(string args)
    {
        List<int> even = new List<int>();
        List<int> odd = new List<int>();

        for (int i = 0; i < args.Length; i++)
        {
            if (i % 2 == 0) even.Add(i);
            else odd.Add(i);
        }
        even.Sort();
        odd.Sort();

        StringBuilder sbeven = new StringBuilder();
        StringBuilder sodd = new StringBuilder();
        foreach (int i in even)
        {
            sbeven.Append(args[i]);
        }
        foreach (int i in odd)
        {
            sodd.Append(args[i]);
        }
        Console.WriteLine(sbeven.ToString() + " " + sodd.ToString());
    }
}
class recordbreaker
{
    public static List<int> breakingRecords(List<int> scores)
    {
        int[] scoresarray = scores.ToArray();
        int min = scoresarray[0];
        int max = scoresarray[0];
        int countmin = 0;
        int countmax = 0;

        for (int i = 0; i < scoresarray.Length; i++)
        {
            if (scoresarray[i] > max) countmax++;
            if (scoresarray[i] < min) countmin++;

            min = min > scoresarray[i] ? scoresarray[i] : min;
            max = max < scoresarray[i] ? scoresarray[i] : max;
        }
        return new List<int>() { countmax, countmin };
    }
    public static void starter(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = breakingRecords(scores);

        /* textWriter.WriteLine(String.Join(" ", result));

         textWriter.Flush();
         textWriter.Close();
        */
        Console.WriteLine(String.Join(" ", result));
    }
}
class BetweenTwoSets
{
    public static void starter(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = getTotalX(arr, brr);

        /* textWriter.WriteLine(total);

         textWriter.Flush();
         textWriter.Close();
        */
        Console.WriteLine(total.ToString());
    }
    static bool CheckF(List<int> v, int x)
    {
        for (int i = 0; i < v.Count; i++)
        {
            if (x % v[i] != 0)
            {
                return false;
            }
        }
        return true;
    }

    static bool CheckS(int x, List<int> v)
    {
        foreach (var i in v)
        {
            if (i % x != 0)
            {
                return false;
            }
        }
        return true;
    }
    public static int getTotalX(List<int> a, List<int> b)
    {
        a.Sort();
        b.Sort();
        int cnt = 0;
        for (int i = a[a.Count - 1]; i <= b[0]; i++)
        {
            if (CheckF(a, i) && CheckS(i, b))
            {
                cnt++;
            }
        }
        return cnt;
    }

}
class NumberLineJumps
{
    public static void starter(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int x1 = Convert.ToInt32(firstMultipleInput[0]);

        int v1 = Convert.ToInt32(firstMultipleInput[1]);

        int x2 = Convert.ToInt32(firstMultipleInput[2]);

        int v2 = Convert.ToInt32(firstMultipleInput[3]);

        string result = kangaroo(x1, v1, x2, v2);

       /* textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
       */
       Console.WriteLine(result);
    }
    public static string kangaroo(int x1, int v1, int x2, int v2)
    {

        string result = "NO";
        for (int j = 1; j < 10000; j++)
        {
            if (x1 + (j * v1) == x2 + (j * v2))
            {
                result = "YES";
            }
        }

        return result;
    }
}
class AppleandOrange
{
    public static void starter(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int s = Convert.ToInt32(firstMultipleInput[0]);

        int t = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int a = Convert.ToInt32(secondMultipleInput[0]);

        int b = Convert.ToInt32(secondMultipleInput[1]);

        string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(thirdMultipleInput[0]);

        int n = Convert.ToInt32(thirdMultipleInput[1]);

        List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

        List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int applecount = 0;
        int orangecount = 0;

        List<int> calapp = new List<int>();
        foreach (int apple in apples)
        {
            calapp.Add(a + apple);
        }
        List<int> calorgn = new List<int>();
        foreach (int orgn in oranges)
        {
            calorgn.Add(b + orgn);
        }

        foreach (int apple in calapp)
        {
            if (apple >= s && apple <= t)
            {
                applecount = applecount + 1;
            }
        }
        foreach (int orange in calorgn)
        {
            if (orange >= s && orange <= t)
            {
                orangecount = orangecount + 1;
            }
        }
        Console.WriteLine(applecount);
        Console.WriteLine(orangecount);
    }
}
class GradingStudents
{
    public static void starter(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result =gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> result = new List<int>();
        foreach (int g in grades)
        {
            if (g < 38)
            {
                result.Add(g);
            }
            else if (g >= 38 && g <= 40)
            {
                result.Add(40);
            }
            else if (g > 40 && g % 5 >= 3)
            {
                float r = g / 5;
                int round = int.Parse(String.Format("{0:0}", r));
                result.Add((round + 1) * 5);
            }
            else result.Add(g);
        }
        return result;
    }
}

