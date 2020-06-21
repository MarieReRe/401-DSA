using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using DataStructures.HashTable;

namespace DataStructures.HashTables
{
   public class RepeatedWord
    {
        public static string RepeatedWords(string sentence)
        {
            if (sentence is null || sentence is "") return null;

            // Splits the input string on spaces & punctuation, keeping hyphens & apostrophes.
            Regex regex = new Regex(@"(?:(?!['-])\W)+");
            string[] words = regex.Split(sentence.ToLower());

            Hashtable hashtable = new Hashtable(10);
            for (int i = 0; i < words.Length; i++)
            {
                if (hashtable.Contains(words[i])) return words[i];
                else hashtable.Add(words[i], words[i]);
            }

            return null;

        }
    }
}
