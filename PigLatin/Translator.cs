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
            char firstChar = v[0];
            string result = null;
            bool checker = true;

            if(!libary.Contains(firstChar.ToString()))
            {
                while(checker)
                {

                }
            }
            else
            {

            }


            for (int i = 0; i < libary.Length; i++)
            {
                if (firstChar.ToString() == libary[i])
                {
                    result = v  + "ay";
                    i = libary.Length;
                }
                else if (firstChar.ToString() != libary[i])
                {
                    string s1 = v.Substring(1, v.Length - 1);
                    result = s1 + firstChar.ToString() + "ay";
                }
            }

            return result;
        }
    }
}