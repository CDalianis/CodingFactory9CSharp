using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        //Returns repeated string n times

        public static string RepeatString(string str, int n)
        {
            StringBuilder sb = new(); // C# 9.0 new()

            for (int i = 0; i < n; i++)
            {
                sb.Append(str);
            }

            return sb.ToString();
        }




        //Creates a random pin of 4 digits

        public static string GeneratePin()
        {

            Random rand = new();

            return rand.Next(1000, 10000).ToString(); // 1000 to 9999
        }


    }
}
