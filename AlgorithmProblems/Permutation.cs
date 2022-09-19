using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    internal class Permutation
    {
        public static void permute(String s, String answer)
        {
            if(s.Length==0)
            {
                Console.WriteLine(answer + " ");
                return;
            }
            for(int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                String left_substr = s.Substring(0, i);
                String right_substr = s.Substring(i + 1);
                String rest = left_substr + right_substr;
                permute(rest, answer + ch);
            }
        }
        public static void Permulate()
        {
            String s;
            String answer=" ";
            Console.WriteLine(" || Enter the string for Permutation || ");
            s= Console.ReadLine();
            Console.WriteLine("\nALL possible strings are : ");
            permute(s, answer);
        }
    }
}