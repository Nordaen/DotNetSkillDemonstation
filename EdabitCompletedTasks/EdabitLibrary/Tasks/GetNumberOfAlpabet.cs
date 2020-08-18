using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EdabitLibrary.Tasks
{
   public class GetNumberOfAlpabet : EdabitTask
    {
        public GetNumberOfAlpabet()
        {
            Name = "Replace Letters With Position In Alphabet";
            Description = "Create a function that takes a string and replaces each letter with its appropriate position in the alphabet. a is 1, b is 2, c is 3, etc, etc.";
        }

        public string GetNumbersAlphabetFromString(string str)
        {
            StringBuilder sb = new StringBuilder();
            
            str = str.ToUpper();
            Dictionary<char, int> keyValuePairs = GetAlphabetDictionary();

            foreach (char ch in str)
            {
                if (ch.Equals(' '))
                {
                    sb.Append(" ");
                    continue;
                }
               
                if (keyValuePairs.TryGetValue(ch, out int value))
                {
                    sb.Append(value);
                }


            }
            return sb.ToString();
        }


        private Dictionary<char,int> GetAlphabetDictionary()
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

            for (int i = 0; i < alpha.Length; i++)
            {
                keyValuePairs.Add(alpha[i], i+1);
            }         
            return keyValuePairs;
        }
    }
}
