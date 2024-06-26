using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        public static bool IsPalindrome(string thestr)
        {
            /* Determine whether a string is a palindrome. 
            You must ignore punctuation & spaces
            Include parameter teststr which must be non empty to test for palindrome 
            and boolean to validate true or false*/

            string[] teststr = {"Hello World!", "Race car!", "Rotor", "More cowbell!", "Madam, I'm Adam."};


            //Convert string to uppercase
            teststr = thestr.ToUpper();

            //Using StringBuilder to remove punctuation
            var sb = new StringBuilder();
            foreach (char c in teststr) {
            
            //Add charecters to the builder if not punctuation or whitespace
            if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                }

            }
            //Convert the builder to a finished string
            teststr = sb.ToString();

            //Compare charecters strating at beginning and end of string
            int i=0, j = teststr.Length - 1;

            //If the indexes cross each other then end loop
            while (i <=j)
            {
                //If the charecter at each index does't match , it's not a palindrome
                if (teststr[i] != teststr[j])
                {
                    return false;
                }
                //Update the counters and try again
                i++;
                j--;
            }
            //At this point string is a palindrome
            return true;
        }
        
    }
}
