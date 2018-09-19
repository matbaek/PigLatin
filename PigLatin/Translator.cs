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
            
            while (checker) // Checker om "checker" er true/false
            {
                if (!libary.Contains(testChar.ToString())) // Checker om vores udtaget bogstav er i vores "libary"
                {
                    tempChar += testChar.ToString(); // Gemmer det udtaget bogstav i en midlertidig variable
                    tempLastPart = s1; // Gemmer det resterende ord i en midlertidig variable

                    testChar = s1[0]; // Finder det næste bogstav i det resterende ord og gemmer i "testChar"
                    s1 = s1.Substring(1); // Finder det resterende ord og gemmer i "s1"
                }
                else 
                {
                    if(tempChar == "") // Checker om "tempChar" er tom
                    {
                        tempLastPart = v; // Sætter "tempLastPart" til at være "v"
                    }

                    checker = false; // Sætter "checker" til false
                }
            }
            
            return tempLastPart + tempChar + "ay"; // Printer ud
        }
    }
}