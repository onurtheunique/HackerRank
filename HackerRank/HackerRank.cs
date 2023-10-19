using Microsoft.VisualBasic;
using System.Collections;
using System.Data;
using System.Reflection.PortableExecutable;
using System.Runtime.Serialization.Formatters;
using System.Text;

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
        //NumberLineJumps.starter(args);
        //GradingStudents.starter(args);
        //questions.mirror(args);
        //DictionariesAndMaps.starter(args);
        //HurdleRace.starter(args);
        //DesignerPDFViewer.starter(args);
        //ElectronicsShop.starter(args);
        //Factorial.starter(args);
        //BinaryNumbers.starter(args);
        //UtopianTree.starter(args);
        //AngryProfessor.starter(args);
        //hourglass.starter(args);
        //BeautifulDaysattheMovies.starter(args);
        //Inheritance.starter();
        //LinkedList.starter(args);
        //Scope.starter(args);
        //FindDigits.starter(args);
        //viralAdvertisingn.Starter(args);
        //BadString.Starter(args);
        //SubarrayDivision.Starter(args);
        //MoreExceptions.Starter(args);
        //Palindrom.Starter(args);
        //Interfaces.Starter(args);
        //FunnyString.Starter(args);
        //Gemstones.Starter(args);
        //Sorting.Starter(args);
        //CleanNodes.Starter(args);
        //Mailbook.Starter(args);
        //MigratoryBirds.Starter(args);
        //Socks.Starter(args);
        //BillDivision.Starter(args);
        //DrawingBook.Starter(args);
        //CountingValleys.Starter(args);
        //IsPrimeOptimised.Starter(args);
        //NestedLogic.Starter(args);
        //BitWise.Starter(args);
 	    //LisasWorkbook.Starter(args);
        //PickingNumbers.Starter(args);
        //CutTheSticks.Starter(args);
        //DivisibleSumPairs.Starter(args);
        //SaveThePrisoner.Starter(args);
        //LisasWorkbook.Starter(args);
        //PickingNumbers.Starter(args);
        //CutTheSticks.Starter(args);
        //JumpingOnTheCloudsRevisited.Starter(args);
        //AppendandDelete.Starter(args);
        //GameofThronesI.Starter(args);
        //TimeInWords.Starter(args);
        //FormingaMagicSquare.Starter(args);
        //ChocolateFeast.Starter(args);
        //ACMICPCTeam.Starter(args);
        //TaumandBday.Starter(args);
        // ModifiedKaprekarNumbers.Starter(args);
        //IntrotoTutorialChallenges.Starter(args);
        //CaesarCipher.Starter(args);
        //InsertionSortPart1.Starter(args);
        SherlockandSquares.Starter(args);
        Console.ReadLine();
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
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = gradingStudents(grades);

        /*  textWriter.WriteLine(String.Join("\n", result));

          textWriter.Flush();
          textWriter.Close();
        */
        Console.WriteLine(String.Join("\n", result));
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
class DictionariesAndMaps
{
    public static void starter(String[] args)
    {
        int n = int.Parse(Console.ReadLine().TrimEnd());
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        string[] search = new string[n];
        for (int i = 0; i < n; i++)
        {
            string[] entry = Console.ReadLine().TrimEnd().Split(' ').ToArray();
            phonebook.Add(entry[0], entry[1]);
        }
        int j = 0;
        string input;
        while (!string.IsNullOrEmpty(input = Console.ReadLine().TrimEnd()))
        {
            search[j] = input;
            j++;
        }
        search = search.Where(w => w != null).ToArray();
        for (int i = 0; i < search.Length; i++)
        {
            if (string.IsNullOrEmpty(search[i]))
            { i = search.Length + 1; break; }
            if (phonebook.ContainsKey(search[i]))
            {
                Console.WriteLine(search[i] + "=" + phonebook[search[i]]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
class HurdleRace
{
    static int hurdleRace(int k, List<int> height)
    {
        int result = (height.Max() - k) >= 0 ? (height.Max() - k) : 0;
        return result;
    }

    public static void starter(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> height = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(heightTemp => Convert.ToInt32(heightTemp)).ToList();

        int result = hurdleRace(k, height);
        /*
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
        */
        Console.WriteLine(result);
    }
}
class DesignerPDFViewer
{
    public static void starter(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();
        string word = Console.ReadLine();
        int result = designerPdfViewer(h, word);
        /*
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();,
        */
        Console.WriteLine(result);
    }
    static int designerPdfViewer(List<int> h, string word)
    {
        Dictionary<char, int> map = mapper(h);
        char[] letters = word.ToUpper().ToCharArray();
        int max = 0;
        foreach (char c in letters)
        {
            max = map[c] > max ? map[c] : max;
        }
        return (word.Length * max);
    }
    private static Dictionary<char, int> mapper(List<int> h)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        char[] letters = "A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z".Split(", ").ToList().Select(s => char.Parse(s)).ToArray();
        for (int i = 0; i < h.Count; i++)
        {
            map.Add(letters[i], h.ToArray()[i]);
        }
        return map;
    }
}
class ElectronicsShop
{
    static int getMoneySpent(int[] keyboards, int[] drives, int b)
    {
        int[] fkeyboards = keyboards.Where(w => w < b).ToArray();
        int[] fdrives = drives.Where(w => w < b).ToArray();

        int result = -1;
        foreach (int k in fkeyboards)
        {
            foreach (int d in fdrives)
            {
                int sum = k + d;
                if (sum <= b)
                {
                    result = sum > result ? sum : result;
                }
            }
        }
        return result;
    }
    public static void starter(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] bnm = Console.ReadLine().Split(' ');

        int b = Convert.ToInt32(bnm[0]);

        int n = Convert.ToInt32(bnm[1]);

        int m = Convert.ToInt32(bnm[2]);

        int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
        ;

        int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
        ;
        /*
         * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
         */

        int moneySpent = getMoneySpent(keyboards, drives, b);
        /*
        textWriter.WriteLine(moneySpent);

        textWriter.Flush();
        textWriter.Close();
        */
        Console.WriteLine(moneySpent);

    }
}
class Factorial
{
    public static void starter(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int result = factorial(n);

        Console.WriteLine(result);
    }
    static int factorial(int n)
    {
        int v = 1;
        for (int i = 1; i <= n; i++)
        {
            v = v * i;
        }
        return v;
    }
}
class BinaryNumbers
{
    static char[] converter(int input)
    {
        return Convert.ToString(input, 2).ToArray();
    }
    private static int repeatcounter(char[] divided)
    {
        int max = 1;
        for (int i = 0; i < divided.Length - 1; i++)
        {
            int rpt = 1;
            for (int j = i + 1; j < divided.Length; j++)
            {
                if (divided[i] == divided[j]) rpt++;
                else break;
            }
            max = max < rpt ? rpt : max;

        }
        return max;
    }
    public static void starter(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        char[] divided = converter(n);
        Console.WriteLine(repeatcounter(divided));
    }


}
class UtopianTree
{

    public static int utopianTree(int n)
    {
        int height = 0;
        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                height++;
            }
            else height = 2 * height;
        }
        return height;
    }

    public static void starter(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = utopianTree(n);

            //textWriter.WriteLine(result);
            Console.WriteLine(result);
        }
        /*
        textWriter.Flush();
        textWriter.Close();
        */
    }
}
class AngryProfessor
{
    public static void starter(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            string result = angryProfessor(k, a);

            Console.WriteLine(result);
            //    textWriter.WriteLine(result);
        }
        /*
        textWriter.Flush();
        textWriter.Close();
        */
    }
    private static string angryProfessor(int k, List<int> a)
    {
        int y = 0;
        foreach (int i in a)
        {
            if (i <= 0) y++;
        }
        string result = y < k ? "YES" : "NO";
        return result;

    }
}
class hourglass
{
    public static void starter(string[] args)
    {

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }
        int[,] matrix = Arcitech(arr);
        int[] result = Logic(matrix);
        //printer(result,matrix);
        Console.WriteLine(result[0]);
    }


    private static int[,] Arcitech(List<List<int>> input)
    {
        int[,] matrix = new int[6, 6];
        int x = 0;
        foreach (List<int> row in input)
        {
            int y = 0;
            foreach (int column in row)
            {
                matrix[x, y] = column;
                y++;
            }
            x++;
        }
        return matrix;
    }
    private static int[] Logic(int[,] matrix)
    {
        int[] result = new int[3] { -9999, 0, 0 };
        for (int x = 0; x < 4; x++)
        {
            for (int y = 0; y < 4; y++)
            {
                int val = matrix[x, y] + matrix[x, y + 1] + matrix[x, y + 2]
                     +
                     matrix[x + 1, y + 1]
                     +
                     matrix[x + 2, y] + matrix[x + 2, y + 1] + matrix[x + 2, y + 2];
                if (result[0] < val)
                {
                    result = new int[] { val, x, y };
                }

            }
        }
        return result;
    }

    private static void printer(int[] result, int[,] matrix)
    {
        Console.WriteLine(matrix[result[1], result[2]].ToString() + " " + matrix[result[1], result[2] + 1].ToString() + " " + matrix[result[1], result[2] + 2].ToString());
        Console.WriteLine("  " + matrix[result[1] + 1, result[2] + 1].ToString() + "  ");
        Console.WriteLine(matrix[result[1] + 2, result[2]].ToString() + " " + matrix[result[1] + 2, result[2] + 1].ToString() + " " + matrix[result[1] + 2, result[2] + 2].ToString());
    }
}
class BeautifulDaysattheMovies
{
    public static void starter(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int i = Convert.ToInt32(firstMultipleInput[0]);

        int j = Convert.ToInt32(firstMultipleInput[1]);

        int k = Convert.ToInt32(firstMultipleInput[2]);

        int result = beautifulDays(i, j, k);
        /*
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
        */
        Console.WriteLine(result);
    }
    public static int beautifulDays(int i, int j, int k)
    {
        int result = 0;
        for (int d = i; d <= j; d++)
        {
            char[] sd = d.ToString().ToArray();
            StringBuilder sb = new StringBuilder();
            for (int x = sd.Length - 1; x >= 0; x--)
            {
                sb.Append(sd[x]);
            }
            int td = int.Parse(sb.ToString());
            float db = float.Parse(Math.Abs(d - td).ToString()) / float.Parse(k.ToString());
            int ib = Math.Abs(d - td) / k;

            if ((db - ib) == 0) result++;
        }


        return result;

    }

}
class Inheritance
{
    public static void starter()
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
    }
    public class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }
    public class Student : Person
    {
        private int[] testScores;

        public Student(string firstName, string lastName, int identification, int[] scores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
            this.testScores = scores;
        }
         public char Calculate()
        {
            int sum= 0;
            foreach (int score in this.testScores) 
            {
                sum += score;
            }
            sum=sum/testScores.Length;
            char result = 'O';
            if (sum < 40) result = 'T';
            else if (sum >= 40 && sum <55) result = 'D';
            else if (sum >= 55 && sum <70) result = 'P';
            else if (sum >= 70 && sum <80) result = 'A';
            else if (sum >= 80 && sum <90) result = 'E';
            return result;
        }

    }
}
class Scope
{
    public class Difference
    {
        private int[] elements;
        public int maximumDifference;
        public Difference()
        {

        }
        public Difference(int[] elmns)
        {
            this.elements = elmns;
        }

        public void computeDifference()
        {
            maximumDifference = int.MinValue;
            foreach (int bs in this.elements)
            {
                foreach (int df in elements)
                {
                    int f = Math.Abs(bs - df);
                    maximumDifference = maximumDifference < f ? f : maximumDifference;
                }
            }
        }


    }
    public static void starter(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}
class LinkedList // Nextvall yeni bir nesne değil sadece pointer!!!!
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }

    private static Node insert(Node head, int data)
    {
        if(head==null)
        {
            return new Node(data);
        }

        Node next = new Node(data);
        Node nextval = head;
        while(nextval.next!=null)
        {
            nextval= nextval.next;
        }
        nextval.next = next;
        return head;

    }

    private static void display(Node head)
    {
        Node start = head;
        while (start != null)
        {
            Console.Write(start.data + " ");
            start = start.next;
        }
    }
    public static void starter(String[] args)
    {

        Node head = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            head = insert(head, data);
        }
        display(head);
    }
}
class FindDigits
{
    public static int findDigits(int n)
    {
            int result = 0;
            char[] numbers = n.ToString().ToArray();
            foreach (char c in numbers)
            {
                int divider = int.Parse(c.ToString());
                if (divider != 0) 
                result = (n % divider == 0) ? result + 1 : result;
            }

            return result;
    }

    public static void starter(string[] args)
    {
       // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result =findDigits(n);

           // textWriter.WriteLine(result);
           Console.WriteLine(result);
        }

      //  textWriter.Flush();
      // textWriter.Close();
    }
}
class viralAdvertisingn
{
    public static void Starter(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        int result = viralAdvertising(n);
        Console.Write(result);
/*
        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
*/
    }
    public static int viralAdvertising(int n)
    {
        double shared = 5.0;
        double liked = 0;
        int sum = 0;
        for(int d = 1;d<=n;d++)
        {
            liked= double.Parse(Math.Floor(shared / 2).ToString());
            sum=sum+int.Parse(liked.ToString());
            shared = (liked * 3);
        }
        return sum;
    }
}
class BadString
{
    public static void Starter(string[] args)
    {
        string S = Console.ReadLine();
        try 
        { Console.WriteLine(int.Parse(S)); } catch { Console.Write("Bad String"); }

    }
}
class SubarrayDivision
{
    public static void Starter(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
        int d = Convert.ToInt32(firstMultipleInput[0]);
        int m = Convert.ToInt32(firstMultipleInput[1]);
        int result = birthday(s, d, m);
/*
        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
*/
    }
    public static int birthday(List<int> s, int d, int m)
    {
        int ways = 0;
        for (var i = 0; i < s.Count; i++)
        {
            var segmentToSum = s.Skip(i).Take(m);
            var segmentSum = segmentToSum.Sum();

            if (segmentSum == d)
            {
                ways++;
            }
        }
        return ways;
    }
}
class MoreExceptions
{
    public static void Starter(String[] args)
    {
        Calculator myCalculator = new Calculator();
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]);
            try
            {
                int ans = myCalculator.power(n, p);
                Console.WriteLine(ans);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
    private class Calculator
    {
        protected int n;
        protected int p;
        public Calculator() { }
        public Calculator(int pn, int pp)
        {
            this.n = pn;
            this.p = pp;
        }
        public  int power(int n,int p)
        {
            if(n<0 || p<0)
            {
                throw new Exception("n and p should be non-negative");          
            }
            int sum = 1;
            for (int i = 0; i < p; i++)
            {
                sum = sum * n;
            }
            return sum;
        }
    }
}
class Palindrom
{
    //Write your code here
    Stack<char> stack = new Stack<char>();
     Queue quete=new Queue();
    public Palindrom()
    {
         
    }

    void pushCharacter(char c)
    {
        stack.Push(c);
    }    
    void enqueueCharacter(char c)
    {
       quete.Enqueue(c);
    }    
      char popCharacter()
    {
        return stack.Pop();
    }       
     char dequeueCharacter()
    {
        return (char)quete.Dequeue();
    }


    public static void Starter(String[] args)
    {
        // read the string s.
        string s = Console.ReadLine();

        // create the Solution class object p.
        //Solution obj = new Solution();
        Palindrom obj = new Palindrom();

        // push/enqueue all the characters of string s to stack.
        foreach (char c in s)
        {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }

        bool isPalindrome = true;

        // pop the top character from stack.
        // dequeue the first character from queue.
        // compare both the characters.
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (obj.popCharacter() != obj.dequeueCharacter())
            {
                isPalindrome = false;

                break;
            }
        }

        // finally print whether string s is palindrome or not.
        if (isPalindrome)
        {
            Console.Write("The word, {0}, is a palindrome.", s);
        }
        else
        {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }
}
class Interfaces
{
    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }
    public class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int sum = 0;
            for (int i=1; i<=n;i++)
            {
                if(n%i == 0) sum=sum+i;
            }

            return sum;
        }
    }
    public static void Starter(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());
        AdvancedArithmetic myCalculator = new Calculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
    }
}
class FunnyString
{
    public static void Starter(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            //string result = Result.funnyString(s);
            string result = funnyString(s);
            Console.WriteLine(result);
        }

    /*        textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    */
    }

    public static string funnyString(string s)
    {
        string result = "Funny";
        char[] arrayr=s.Reverse().ToArray(); 
        char[] arrays = s.ToArray();

     for (int i=1;i<arrays.Length;i++)
        {
            if (Math.Abs((int)arrays[i] - (int)arrays[i - 1]) != Math.Abs((int)arrayr[i] - (int)arrayr[i - 1]))
            { result = "Not " + result; break; }
        }
        return result;
    }

}
class Gemstones
{
    public static int gemstones(List<string> arr)
    {
        int result = 0;
        string[] arrfiltered=Filter(arr);
        int i=0;
            foreach(char c in arrfiltered[i].ToArray())
            {
                bool res = true;
                for(int j=i+1;j<arrfiltered.Length;j++)
                {
                    if (!arrfiltered[j].Contains(c)) res= false;
                }
                result=res?result+1:result;
            }
        return result;
    }

    private static string[] Filter(List<string> arr)
    {
        string[] filtered = new string[arr.Count()];
        int i = 0;
        foreach (string s in arr)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s.ToArray())
            {
                if (!sb.ToString().Contains(c))
                {
                    sb.Append(c);
                }
            }
           filtered[i]=sb.ToString();
            i++;
        }
        return filtered;
    }

    public static void Starter(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> arr = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string arrItem = Console.ReadLine();
            arr.Add(arrItem);
        }

        int result = gemstones(arr);
        /*
        int result = Result.gemstones(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
        */
        Console.WriteLine(result);
    }
}
class Sorting
{
    public static void Starter(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int swaps = 0;

        for (int i = 0; i < n; i++)
        {
            int swapsNumber = 0;

            for (int j = 0; j < n - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int memory = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = memory;
                    swapsNumber++;
                    swaps++;
                }
            }
            if (swapsNumber == 0)
                break;
        }

        Console.WriteLine($"Array is sorted in {swaps} swaps.");
        Console.WriteLine($"First Element: {a[0]}");
        Console.WriteLine($"Last Element: {a[a.Count - 1]}");
    }
}
class CleanNodes
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }
    public static Node removeDuplicates(Node head)
    {
        Node node = head;
        List<int> clearlist = new List<int>();
        while(node!=null)
        {
            if(!clearlist.Contains(node.data))
            {
                clearlist.Add(node.data);
            }
            node = node.next;
        }

        Node basenode = null;
        foreach (var i in clearlist)
        {
            basenode = insert(basenode, i);
        }
        return basenode;
    }

    public static Node insert(Node head, int data)
    {
        Node p = new Node(data);


        if (head == null)
            head = p;
        else if (head.next == null)
            head.next = p;
        else
        {
            Node start = head;
            while (start.next != null)
                start = start.next;
            start.next = p;

        }
        return head;
    }
    public static void display(Node head)
    {
        Node start = head;
        while (start != null)
        {
            Console.Write(start.data + " ");
            start = start.next;
        }
    }
    public static void Starter(String[] args)
    {

        Node head = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            head = insert(head, data);
        }
        head = removeDuplicates(head);
        display(head);
    }
}
class Mailbook
{
        private class book
    {
        public string name;
        public string mail;
            public book() { }
            public book(string name, string mail) { this.name = name; this.mail = mail; }
        public void printName() 
            {
                Console.WriteLine(name);
            }
    }
    public static void Starter(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());

        List<book> adresbook = new List<book>();

        for (int NItr = 0; NItr < N; NItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            string firstName = firstMultipleInput[0];

            string emailID = firstMultipleInput[1];

            string mail = emailID.Split('@')[1].Split('.')[0];
                if (string.Equals("gmail",mail) )
                {
                    adresbook.Add(new book(firstName, mail));
                }

            }
            foreach (book book in adresbook.OrderBy(o => o.name)) 
        { book.printName(); }
        }
}
class MigratoryBirds
{

    public static int migratoryBirds(List<int> arr)
    {
        int[] counts=new int[6];

        for (int i = 1; i < 6; i++)
        {
            counts[i]=arr.Where(w=>w==i).Count();
        }
       return Array.FindIndex(counts, row => row == counts.Max());
    }
    public static void Starter(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = migratoryBirds(arr);
        Console.WriteLine(result);
/*
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
*/
    }
}
class Socks
{

    public static int sockMerchant(int n, List<int> ar)
    {
        int sum = 0;
        foreach (int i in ar.Distinct())
        {
            int count = ar.Where(w => w == i).Count();

            sum = count% 2 == 0 ? sum + (count / 2) : sum + ((count - 1) / 2);

        }
        return sum;
    }
    public static void Starter(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = sockMerchant(n, ar);

       Console.WriteLine(result);
    }
}
class BillDivision
{
    public static void bonAppetit(List<int> bill, int k, int b)
    {
        int[] arrbill=bill.ToArray();
        int sum=0;
        for (int i = 0; i < arrbill.Length; i++) 
        { 
          if(i!=k)  sum += arrbill[i]; 
        }
        if(sum/2==b)
        {
            Console.WriteLine("Bon Appetit");
        }
        else
        {
            Console.WriteLine(Math.Abs(b - (sum / 2)));
        }
    }

    public static void Starter(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

        int b = Convert.ToInt32(Console.ReadLine().Trim());

        bonAppetit(bill, k, b);
    }
}
class DrawingBook
{
    public static void Starter(string[] args)
    {
       // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int result = pageCount(n, p);

        Console.WriteLine(result);
 /*       textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
 */
    }
    public static int pageCount(int n, int p)
    {
        List<int> book = printBook(n);

        int front = book.FindIndex(f => f == p || f == p + 1);
        int back = book.Count()-1 - front;
        if (front < back) return front;
        return back;
    }
    private static List<int> printBook(int n)
    {      
        List<int> book = new List<int>();
        int page = 1;
        book.Add(page);
        while (page < n)
        {
            page = page + 2;
            book.Add(page);
        }
        return book;
    }


}
class CountingValleys
{
    public static int countingValleys(int steps, string path)
    {
        char[] csteps = path.ToArray();
        int terrain=0;
        int count = 0;   
        for (int i = 0; i < steps; i++)
        {         
               switch (csteps[i])
                {
                    case 'U':
                        terrain++;
                        break;
                    case 'D':
                    if (terrain == 0 ) count++;
                        terrain--;
                        break;
                }
        }
        return count;
    }

    public static void Starter(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = countingValleys(steps, path);
        /*
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
        */
        Console.WriteLine(result);
    }
}
class IsPrimeOptimised
{
    public static void Starter(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> a = new List<int>();
        for (int i=0; i<n; i++)
        {
            a.Add(int.Parse(Console.ReadLine().TrimEnd()));
        }
        foreach (int i in a)
        {
           if(IsPrime(i))
            {
                Console.WriteLine("Prime");
            }
           else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
    static bool IsPrime(int num)
    {
        if (num == 1)
        {
            return false;
        }

        if (num % 2 == 0) // test edilecek değerlerin %50 si 2 çift sayı olacağından 2 ye bölünme testini eklemek işi hızlandıracaktır.
        {
            for (int n = 2; n < num; n += 2)
            {
                if (num % n == 0)
                {
                    return false;
                }
            }
        }
        else
        {
            for (int n = 3; n < num; n += 2)
            {
                if (num % n == 0)
                {
                    return false;
                }
            }
        }

        return true;
    }
}
class NestedLogic
{
    public static void Starter(String[] args)
    {
        int[] returndatesections = Array.ConvertAll(Console.ReadLine().Split(' '), sections => Convert.ToInt32(sections));        
        int[] expecreddatesections = Array.ConvertAll(Console.ReadLine().Split(' '), sections => Convert.ToInt32(sections));
        DateTime returndate = new DateTime(day: returndatesections[0], month: returndatesections[1], year: returndatesections[2]);
        DateTime expecreddate = new DateTime(day: expecreddatesections[0], month: expecreddatesections[1], year: expecreddatesections[2]);
        int hectos = 0;
        if (returndate > expecreddate)
        {
            if (returndate.Year == expecreddate.Year && returndate.Month == expecreddate.Month)
            {
                hectos = (returndate.Day - expecreddate.Day) * 15;
            }
            else if(returndate.Year == expecreddate.Year && returndate.Month > expecreddate.Month)
            {
                hectos = (returndate.Month - expecreddate.Month) * 500;
            }else if(returndate.Year > expecreddate.Year)
            {
                hectos = 10000;
            }

           
        } Console.WriteLine(hectos.ToString());
 
    }
}
class BitWise
{
    public static int bitwiseAnd(int N, int K)
    {
        int a;int b;
        int max = 0;
        for (a=1;a<=N-1;a++)
        {
             
            for (b = 2; b <= N; b++)
            {
                if(a<b & (a&b)<K)
                { max = (a & b) > max ? a & b : max;
                }
            }
        }
        return max;
    }
    public static void Starter(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int count = Convert.ToInt32(firstMultipleInput[0]);

            int lim = Convert.ToInt32(firstMultipleInput[1]);

            int res =bitwiseAnd(count, lim);
            Console.WriteLine(res);

        }

    }
}
class LisasWorkbook
{
    public static int workbook(int n, int k, List<int> arr)
    {
        List<int[]> pages = new List<int[]>();
        List<int[]> chapters = new List<int[]>();
        int hits = 0;
        foreach (int i in arr)
        {
            List<int> problems = new List<int>();
            for (int p = 1; p <= i; p++)
            {
                problems.Add(p);
            }
            chapters.Add(problems.ToArray());
        }
        foreach (int[] i in chapters)
        {
            int counter = 0;
            List<int> page = new List<int>();
            for (int r = 0; r < i.Length; r++)
            {
                if (counter == k)
                {
                    pages.Add(page.ToArray());
                    counter = 0;
                    page.Clear();
                }
                page.Add(i[r]);
                counter++;
                if (r == i.Length - 1) pages.Add(page.ToArray());
            }

        }
        for (int i = 0; i < pages.Count(); i++)
        {
            if (pages[i].Contains(i + 1)) hits++;
        }
        return hits;
    }
    public static void Starter(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = workbook(n, k, arr);
        Console.WriteLine(result);

    }
}
class PickingNumbers
{
    public static int pickingNumbers(List<int> a)
    {
        int max = 0;
        a = a.OrderBy(i => i).ToList();
        foreach (int i in a)
        {
            int count = a.Where(w => w == i || w == i + 1).Count();
            max = count > max ? count : max;
        }
        return max;
    }

    public static void Starter(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = pickingNumbers(a);

        Console.WriteLine(result);
    }
}
class CutTheSticks
{
    private static List<int> cutTheSticks(List<int> arr)
    {
        int[] ar = arr.ToArray();
        List<int> result = new List<int>();
        while (ar.Max() > 0)
        {
            int min = ar.Where(w => w > 0).Min();
            int hit = 0;
            for (int i = 0; i < arr.Count(); i++)
            {
                if (ar[i] >= min)
                {
                    ar[i] = ar[i] - min;
                    hit++;
                }
            }
            result.Add(hit);
        }
        return result;
    }
    public static void Starter(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = cutTheSticks(arr);

        Console.WriteLine(String.Join("\n", result));
    }
}
class DivisibleSumPairs
{
    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        int count = 0;
        int[] array = ar.ToArray();

        for(int i=0;i<ar.Count-1;i++)
        {
            for(int j=1;j<ar.Count;j++)
            {
                if( i < j && (ar[i] + ar[j])%k==0)
                {
                    count++;
                }
            }
        }
        return count;
    }
    public static void Starter(string[] args)
    {

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = divisibleSumPairs(n, k, ar);

        Console.WriteLine(result);
    }
}
class SaveThePrisoner
{
    public static int saveThePrisoner(int n, int m, int s)
    {
        return (s - 1 + m - 1) % n + 1;
    }

    public static void Starter(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

class JumpingOnTheCloudsRevisited
{
    private class refac
    {
        int val { get; set; }
        int loc { get; set; }
        refac(int val,int loc)
        {
            this.val = val;
            this.loc = loc;
        }
    }
    private static int jumpingOnClouds(int[] c, int k)
    {
        int sum = 0;
        int i = 0;
        bool p = true;
        while (i!=0 || p)
        {
            p = false;
            i = (i + k) % c.Count();
            sum = c[i] == 0 ? sum = sum + 1 : sum = sum + 3;
        }
        return 100-sum;
    }
    public static void Starter(string[] args)
    {
        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = jumpingOnClouds(c, k);
        Console.WriteLine(result);
    }
}
class AppendandDelete
{
    private static string appendAndDelete(string s, string t, int k)
    {
        int endofsim = 0;
        string sl= s.Length < t.Length ? s : t;
        for (int i = 0;i<sl.Length;i++) 
        {
            if (s[i] != t[i])
            {
                break;
            }
            endofsim = i + 1;
        }
        string res = "No";
        int sCount = s.Length - endofsim;
        int tCount = t.Length - endofsim;
        int totalOps = sCount + tCount;

        if (k >= totalOps && (k - totalOps) % 2 == 0)
        {
            res= "Yes";
        }

        return res;
    }
    public static void Starter(string[] args)
    {
        string s = Console.ReadLine();

        string t = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = appendAndDelete(s, t, k);
        Console.WriteLine(result);   
    }
}
class GameofThronesI
{
    public static void Starter(string[] args)
    {
        string s = Console.ReadLine();
        string result = gameOfThrones(s);
        Console.WriteLine(result);
    }
    private static string gameOfThrones(string s)
    {
        List<char> list = s.ToArray().Distinct().ToList();
        int counter = 0;
        foreach (char c in list) 
        {
            if (s.Where(x => x == c).Count() % 2 != 0) counter++;
        }
        if ((counter == 1 && s.Length % 2 == 1) || (counter == 0 && s.Length % 2 == 0))
        {
            return "YES";
        }
        else
        {
            return "NO";
        }
        }
}
class TimeInWords
{
    public static void Starter(string[] args)
    {
        int h = Convert.ToInt32(Console.ReadLine().Trim());
        int m = Convert.ToInt32(Console.ReadLine().Trim());
        string result = timeInWords(h, m);
        Console.WriteLine(result);
    }
    private static string timeInWords(int h, int m)
    {
        String[] timeText = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty", "twenty one", "twenty two", "twenty three", "twenty four", "twenty five", "twenty six", "twenty seven", "twenty eight", "twenty nine" };

        if (m == 0) return timeText[h - 1] + " o' clock";
        if (m == 1) return "one minute past " + timeText[h - 1];
        if (m == 15) return "quarter past " + timeText[h - 1];
        if (m == 45) return "quarter to " + timeText[h];
        if (m == 30) return "half past " + timeText[h - 1];
        if (m > 30) return timeText[60 - m - 1] + " minutes to " + timeText[h];
        return timeText[m - 1] + " minutes past " + timeText[h - 1];
    }
}
class FormingaMagicSquare
{
    public static void Starter(string[] args)
    {
        List<List<int>> s = new List<List<int>>();

        for (int i = 0; i < 3; i++)
        {
            s.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList());
        }

        int result = formingMagicSquare(s);

        Console.WriteLine(result);

    }
    private static int formingMagicSquare(List<List<int>> s)
    {
        int result = 0;
        int[,] matris = MatrisMaker(s);
        List<int> maxsum = MatrisColumnSum(matris);

        foreach (List<int> list in s)
        {
            maxsum.Add(list.Sum());
        }
        maxsum = maxsum.Distinct().OrderByDescending(x => x).ToList();
        return result;
    }

    private static List<int> MatrisColumnSum(int[,] matris)
    {
        List<int> maxsum = new List<int>();

        for (int x = 0; x < 3; x++)
        {
            maxsum.Add(matris[0, x] + matris[1, x] + matris[2, x]);
        }
        return maxsum;
    }

    private static int[,] MatrisMaker(List<List<int>> s)
    {
        int[,] matris = new int[3, 3];
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                matris[x, y] = s.ToArray()[y].ToArray()[x];
            }
            int sum = s.ToList()[x].Sum();
        }

        return matris;
    }
}
class ChocolateFeast
{

    public static void Starter(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());
        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int c = Convert.ToInt32(firstMultipleInput[1]);
            int m = Convert.ToInt32(firstMultipleInput[2]);
            int result = chocolateFeast(n, c, m);
            Console.WriteLine(result);
        }
    }
    public static int chocolateFeast(int n, int c, int m)
    {
        int choco = 0;
        int wraps = 0;

        while (n >= c) 
        {
            choco++;
            wraps++;
            n = n - c;
        }
        while (wraps>=m)
        {
            choco++;
            wraps++;
            wraps=wraps - m;
        }


        return choco;
    }
}
class ACMICPCTeam
{
    public static void Starter(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
        int n = Convert.ToInt32(firstMultipleInput[0]);
        int m = Convert.ToInt32(firstMultipleInput[1]);
        List<string> topic = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string topicItem = Console.ReadLine();
            topic.Add(topicItem);
        }
        List<int> result = acmTeam(topic);
        Console.WriteLine(String.Join("\n", result));
    }
    #region mycode
    /*
    public static List<int> acmTeam(List<string> topic)
    {
        List<int> result = new List<int>();
        List<int> tops = new List<int>();
        string[] topics = topic.ToArray();
        int max = int.MinValue;
        for (int i = 0; i < topics.Length; i++)
        {
            for( int j = i+1; j < topics.Length;j++)
            {
                int sum = Calculator(topics, i, j);
                if (sum >= max)
                {
                    max = sum;
                    tops.Add(sum);
                }
            }
        }
      result.Add(max); result.Add(tops.Where(w=>w==max).Count());
        return result;
    }

    private static int Calculator(string[] topics, int i, int j)
    {
        int sum = 0;
        for (int x = 0; x < topics[i].Length; x++)
        {
            int sit = int.Parse(topics[i].ToCharArray()[x].ToString()) + int.Parse(topics[j].ToCharArray()[x].ToString());
            sum = sit > 0 ? sum = sum + 1 : sum;
        }
        return sum;
    }
    */
    #endregion
    public static List<int> acmTeam(List<string> topic)
    {
        List<int> result = new List<int>();
        int maxTopics = 0;
        int maxTeams = 0;

        for (int i = 0; i < topic.Count - 1; i++)
        {
            for (int j = i + 1; j < topic.Count; j++)
            {
                int sum = Calculator(topic[i], topic[j]);

                if (sum > maxTopics)
                {
                    maxTopics = sum;
                    maxTeams = 1;
                }
                else if (sum == maxTopics)
                {
                    maxTeams++;
                }
            }
        }

        result.Add(maxTopics);
        result.Add(maxTeams);

        return result;
    }

    private static int Calculator(string a, string b)
    {
        int sum = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == '1' || b[i] == '1')
            {
                sum++;
            }
        }

        return sum;
    }

}
class TaumandBday
{
    public static void Starter(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');


            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int s = Convert.ToInt32(firstMultipleInput[2]);

            int result = saveThePrisoner(n, m, s);
            /*
                        textWriter.WriteLine(result);
                    }

                    textWriter.Flush();
                    textWriter.Close();
            */
            Console.WriteLine(result);
        }
    }
}

            int b = Convert.ToInt32(firstMultipleInput[0]);

            int w = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int bc = Convert.ToInt32(secondMultipleInput[0]);

            int wc = Convert.ToInt32(secondMultipleInput[1]);

            int z = Convert.ToInt32(secondMultipleInput[2]);

            long result =taumBday(b, w, bc, wc, z);

            Console.WriteLine(result);
        }
    }
    private static long taumBday(int b, int w, int bc, int wc, int z)
    {
        long lb=long.Parse(b.ToString());
        long lw=long.Parse(w.ToString());
        long lbc=long.Parse(bc.ToString());
        long lwc=long.Parse(wc.ToString());
        long lz=long.Parse(z.ToString());
        long basecost=(lb*lbc)+(lw*lwc);
        long allw = ((lb+lw)*lwc) + (lb*lz);
        long allb = ((lb+lw)*lbc) + (lw*lz);
        return Math.Min(basecost,Math.Min(allw,allb));  
    }
}
class ModifiedKaprekarNumbers
{
    public static void Starter(string[] args)
    {
        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        kaprekarNumbers(p, q);
    }
    public static void kaprekarNumbers(int p, int q)
    {
        List<int> baselist=ListCraeator(p, q);
        List<string> Result=new List<string>();
        foreach (int r in baselist) 
        {
            if(split(r))
            {
                Result.Add(r.ToString());
            }
        }
        if (Result.Count ==0) { Console.WriteLine("INVALID RANGE"); }
        Console.WriteLine(string.Join(" ", Result));
    }
    private static bool split(long r)
    {
        if (r == 1) return true;
        string val = (r * r).ToString();
        int cnt = val.Length;
        if (cnt < 2) return false;
        int fh = 0;
        int sh=0;
        if (cnt % 2 == 0 && cnt>1)
        {
            fh = int.Parse(val.Substring(0, cnt/2).ToString());
            sh = int.Parse(val.Substring(cnt/2).ToString());
        }
        else
        {
            fh = int.Parse(val.Substring(0, (cnt-1)/2).ToString());
            sh = int.Parse(val.Substring((cnt-1)/2).ToString());
        }
        
        if (r == (fh + sh)) return true;  
        return false;
    }

    private static List<int> ListCraeator(int p, int q)
    {
        List<int> list = new List<int>();
        for (int i = p; i <=q; i++)
        {
            list.Add(i);
        }
        return list;
    }
}
class IntrotoTutorialChallenges
{
    public static void Starter(string[] args)
    {
        int V = Convert.ToInt32(Console.ReadLine().Trim());
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        int result = introTutorial(V, arr);
        Console.WriteLine(result);
    }
    private static int introTutorial(int V, List<int> arr)
    {
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr.ToArray()[i] == V)
            {
                return i;
            }
        }
        return 0;
    }
}
class CaesarCipher
{
    public static void Starter(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        string s = Console.ReadLine();
        int k = Convert.ToInt32(Console.ReadLine().Trim());
        string result =caesarCipher(s, k);
        Console.WriteLine(result);
    }

    private static string caesarCipher(string s, int k)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        char[] calphabet = alphabet.ToCharArray();
        k = k % calphabet.Length;
        char[] crotated = AlphabetBuilder(k, alphabet);
        char[] crypted = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            char c = s.ToCharArray()[i];
            bool upper = false;
            if (Char.IsUpper(c))
            {
                c=Char.ToLower(c);
                upper = true;
            }
            if (calphabet.Contains(c))
            {
                int num = Array.IndexOf(calphabet, c);
                crypted[i] = crotated[num];
                if (upper) crypted[i] = Char.ToUpper(crypted[i]);
            }
            else
            {
                crypted[i] = s.ToCharArray()[i];
            }
        }
        
        return ArrayToString(crypted);
    }

    private static string ArrayToString(char[] crypted)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in crypted)
        {
            sb.Append(c);
        }
       return sb.ToString();
    }

    private static char[] AlphabetBuilder(int k,string alph)
    {
        string dualalphabet = alph + alph;
        char[] rotatedalphabet = new char[alph.Length];
        for (int i = 0; i < alph.Length; i++)
        {
            rotatedalphabet[i] = dualalphabet.ToCharArray()[i + k];
        }
        return rotatedalphabet;
    }
}
class InsertionSortPart1
{
    public static void Starter(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        insertionSort1(n, arr);
    }

    private static void insertionSort1(int n, List<int> arr)
    {
        int sort = arr[arr.Count() - 1];
        arr[arr.Count() - 1] =arr[arr.Count()-2];   
            for (int i=arr.Count-1; i >0 ;i--) 
            {
                    if (arr[i-1]<sort)
                {
                    arr[i] = sort;
                    Console.WriteLine(String.Join(' ', arr));
                    break;
                }
                arr[i] = arr[i - 1];
            Console.WriteLine(String.Join(' ',arr));             
            }
        
    }

    

}
class SherlockandSquares
{
    public static void Starter(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());
        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int a = Convert.ToInt32(firstMultipleInput[0]);
            int b = Convert.ToInt32(firstMultipleInput[1]);
            int result = squares(a, b);
            Console.WriteLine(result);
        }
    }
    private static int squares(int a, int b)
    {
        int count = 0;
        for(int i = a; i <= b;i++)
        {
            if (Math.Sqrt(i) % 1 == 0) count++;
        }
        return count;
    }

}
