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
            string[] libary = new string[] {"a", "e", "i", "o"}; // Laver et bibliotek over bogstaver
            string[] words = v.Split(' '); // Splitter "v" op, for at se om der er flere ord

            string result = null;

            for (int i = 0; i < words.Length; i++) // Køre igenne "words"
            {

                bool checker = true;

                string tempLastPart = ""; // Midlertidigt variable til at gemme sidste delen af ordet 
                string tempChar = ""; // Midlertidigt variable til at gemme første bogstav

                char testChar = words[i][0]; // Første bogstav i "words[i]"
                string s1 = words[i].Substring(1, words[i].Length - 1); // Finder ud af hvad sidste delen af "words[i]" er
            
                while (checker) // Checker om "checker" er true/false
                {
                    if (!libary.Contains(testChar.ToString())) // Checker om vores udtaget bogstav ikke er i vores "libary"
                    {
                        tempChar += testChar.ToString(); // Gemmer det udtaget bogstav i en midlertidig variable
                        tempLastPart = s1; // Gemmer det resterende ord i en midlertidig variable

                        testChar = s1[0]; // Finder det næste bogstav i det resterende ord og gemmer i "testChar"
                        s1 = s1.Substring(1, s1.Length - 1); // Finder det resterende ord og gemmer i "s1"
                    }
                    else 
                    {
                        if(tempChar == "") // Checker om "tempChar" er tom
                        {
                            tempLastPart = words[i]; // Sætter "tempLastPart" til at være "v"
                        }

                        checker = false; // Sætter "checker" til false
                        result += tempLastPart + tempChar + "ay "; // Gemmer resultatet
                    }

                }
            }

            return result.TrimEnd(); // Printer resultatet ud
        }
    }
}