using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    public class Translator
    {
        public string Translate(string v)
        {
            string[] libary = new string[] {"a", "e", "i", "o"};
            char testChar = v[0];
            bool checker = true;

            string tempLastPart = "";
            string tempChar = "";
            string s1 = v.Substring(1, v.Length - 1);

            while (checker)
            {
                if (!libary.Contains(testChar.ToString()))
                {
                    tempChar += testChar.ToString();
                    tempLastPart = s1;

                    testChar = s1[0];
                    s1 = s1.Substring(1);
                }
                else 
                {
                    if(tempChar == "")
                    {
                        tempLastPart = v;
                    }

                    checker = false;
                }
            }
            
            return tempLastPart + tempChar + "ay";
        }
    }
}