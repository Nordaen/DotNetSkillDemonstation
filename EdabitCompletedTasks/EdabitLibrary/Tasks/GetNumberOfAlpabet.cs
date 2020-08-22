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
        /// <summary>
        /// Return int representation of char's position in alphabet
        /// </summary>
        /// <param name="str">input string</param>
        /// <returns></returns>
        public string GetNumbersAlphabetFromString(string str)
        {
            //create StringBuilder for contatunate strings (instead of creating one)
            StringBuilder sb = new StringBuilder();
            //get input string to upper case as mask
            str = str.ToUpper();
            //get dictionary of alphabet chars and positions
            Dictionary<char, int> keyValuePairs = GetAlphabetDictionary();
            //create in cycle output string
            foreach (char ch in str)
            {
                //if we found space - add slash
                if (ch.Equals(' '))
                {
                    sb.Append("/");
                }
               //get value from dictionary
                if (keyValuePairs.TryGetValue(ch, out int value))
                {
                    sb.Append(value);
                    sb.Append(" ");
                }


            }
            
            //remove last space from string
            char st = sb[sb.Length-1];
            if (st ==' ')
            {
                sb.Remove(sb.Length - 1, 1);
            }
            //return string
            return sb.ToString();
        }

        /// <summary>
        /// create dictionary, where int key is letter in alphabet and value is position
        /// </summary>
        /// <returns></returns>
        private Dictionary<char,int> GetAlphabetDictionary()
        {
            //create mask for filling dictionary
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            //add word and it's position
            for (int i = 0; i < alpha.Length; i++)
            {
                keyValuePairs.Add(alpha[i], i+1);
            }         
            //return dictionary
            return keyValuePairs;
        }
    }
}
