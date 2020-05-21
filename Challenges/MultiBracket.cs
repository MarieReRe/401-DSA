using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges
{
    public class MultiBracket
    {
        public static bool IsMatched(string input)
        {
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
            {
                {'(', ')'},
                {'{', '}'},
                {'[', ']'},
                {'<', '>'}
            };
            Stack<char> brackets = new Stack<char>();
         
            try
            {
                // Iterate through each character in the input string
                foreach (char c in input)
                {
                    if (bracketPairs.Keys.Contains(c))
                    {
                        brackets.Push(c);
                    }
                    else
                        // check if the character is one of the 'closing' brackets
                    if (bracketPairs.Values.Contains(c))
                    {
                        if (c == bracketPairs[brackets.First()])
                        {
                            brackets.Pop();
                        }
                        else
                            // if not, its an unbalanced string
                            return false;
                    }
                    else
                        // continue looking
                        continue;
                }
            }
            catch
            {

                return false;
            }

            // Ensure all brackets are closed

            return brackets.Count() == 0 ? true : false;


        }


    }
}
