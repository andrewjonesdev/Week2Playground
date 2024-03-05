using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Week2Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char A = (char)65;
            char z = (char)122;
            List<char> charList = new List<char>();
            Console.WriteLine($"{A}-{z}");
            for (int x = 65; x <= 90; x++)
            {
                Console.WriteLine((char)x);
                charList.Add((char)x);
            }

            foreach (char x in charList)
            {
                Console.Write($"\t\"{x}\"\n");
                Console.Write("\t\"letter " + x + " end \"\n");
            }

            StringBuilder crew = new StringBuilder("Straw", 50);
            Console.WriteLine($"1: There are {crew.Length} chars in {crew.ToString()}");
            crew.Append(new char[] { 'h', 'a', 't' });
            Console.WriteLine($"2: There are {crew.Length} chars in {crew.ToString()}");
            crew.AppendFormat("hat {0}", "Crew");
            Console.WriteLine($"3: There are {crew.Length} chars in {crew.ToString()}");
            crew.Insert(0, "The ");
            Console.WriteLine($"4: There are {crew.Length} chars in {crew.ToString()}");
            crew.Replace("The", "Yonko Empire:");
            Console.WriteLine($"5: There are {crew.Length} chars in {crew.ToString()}");

            Console.WriteLine($"{(YonkoMembers)19} is {YonkoMembers.Luffy}\nShanks is {YonkoMembers.Shanks}\nBuggy is {YonkoMembers.Buggy}\nBlackbeard is {YonkoMembers.Blackbeard}");

            bool truth = false;



            int five = 5;
            int six = 6;
            int a = five > six ? 1 : 2;
            do
            {


                Console.WriteLine(a);
                five++;
            } while (five > six);

            while (five > six)
            {
                Console.WriteLine(a);
                five++;
            }
            if (five > six)
            {
                Console.WriteLine("The One Piece is Real");
                a = 1;
            }
            else
            {
                Console.WriteLine("Imu is my lord and savior");
                a = 2;
            }

            DateTime current = DateTime.Now;
            Console.WriteLine(current.ToString());
            DateTime friday = new DateTime(2024, 3, 1);
            Console.WriteLine(friday.ToString());

            Guid newId = Guid.NewGuid();
            Guid newId2 = Guid.NewGuid();
            Console.WriteLine(newId + " " + newId2);
            {
                (string, int) yonko = ("shanks", 39);
                Console.WriteLine($"Did you know {yonko.Item1} is {yonko.Item2} years old ? ");
            }
            {
                (string Name, int Age) yonko = ("shanks", 39);
                Console.WriteLine($"Did you know {yonko.Name} is {yonko.Age} years old ? ");
            }
            {
                var evil = "Blackbeard";
                Console.WriteLine(evil.Length);
                Console.WriteLine(evil.Laugh);
            }
            {
                dynamic evil = "Blackbeard";
                Console.WriteLine(evil.Length);
                Console.WriteLine(evil.Laugh);
            }
            {
                string law = "supernova";
                Console.WriteLine(law);
            }
            Console.WriteLine(law.Length);

            string shanks, luffy, buggy, blackbeard;
            shanks = luffy = buggy = blackbeard = string.Empty;

            int a = 5;
            Console.WriteLine($"Suffix a: {a} and\nb: {a++} ");
            Console.WriteLine($"a: {a} after increment suffix");

            a = 5;
            Console.WriteLine($"Prefix a: {a} and\nb: {++a} ");

        }
    }


    public enum YonkoMembers { 
    
    Luffy = 19,
    Shanks = 39,
    Buggy = 38,
    Blackbeard = 40
    }
}
