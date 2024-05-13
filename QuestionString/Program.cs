using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoveFirstLast();
            Console.WriteLine();
            Console.WriteLine(consecutive());
            //consecutive();

            Console.WriteLine();
            Console.WriteLine(Brakets());

            Console.WriteLine();
            Console.WriteLine(AddLastFirst());

            Console.WriteLine();
            Console.WriteLine(startwith());

            Console.WriteLine();
            Console.WriteLine(endwith());

        }

        public static void RemoveFirstLast()
        {
            string s = "hello";
            Console.WriteLine(s);

            Console.WriteLine("After remove first and last");
            Console.WriteLine(s.Length > 2 ? s.Substring(1, s.Length-2) : s);

        }


        public static bool consecutive()
        {
            string s = "hello";

            Console.WriteLine(s);

            for(int i = 0; i < s.Length-1; i++)
            {
                if (s[i] == s[i+1])
                {
                    return true;
                    //Console.WriteLine("True");
                }
                
            }

            return false;
        }

        public static bool Brakets()
        {
            string s = "{<()>}";
            Console.WriteLine(s);

            Stack<char> ch = new Stack<char>();

            foreach(char i in s.ToCharArray())
            {
                if(i == '(')
                {
                    ch.Push(')');
                }
                else if(i == '{')
                {
                    ch.Push('}');
                }
                else if(i == '<')
                {
                    ch.Push('>');
                }
                else if(i == '[')
                {
                    ch.Push(']');
                }
                else if(ch.Count == 0 || ch.Pop() != i)
                {
                    return false;
                }
            }

            return ch.Count == 0;

        }


        public static string AddLastFirst()
        {
            string s = "abcd";
            Console.WriteLine(s);

            var str = s.Substring(s.Length-1);

            Console.WriteLine("Adding last to last and first");
            //Console.WriteLine(str+s+str);

            return str + s + str;
        }


        public static bool startwith()
        {
            string s = "c#-sharp";
            Console.WriteLine(s);

            string s1 = "c#";
            Console.WriteLine("String start with {0}", s1);

            if (s.StartsWith(s1))
            {
                return true;
            }
            
            return false;

        }


        public static bool endwith()
        {
            string s = "C#-sharp";
            Console.WriteLine(s);

            string s1 = "rp";

            Console.WriteLine("String end with {0}",s1);

            if (s.EndsWith(s1))
            {
                return true;
            }

            return false;
        }
    }
}
