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
        //evenodddivder.starter(args);
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

class evenodddivder
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
