using System;

namespace CodingChallenges
{
    public class CC47
    {       
        public static string Encrypt(string word)
        {
            char c;
            string newWord = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 'a' && word[i] <= 'z')
                    c = (char)(219 - (byte)word[i]); // 'a' + 'z'
                else
                    c = (char)(155 - (byte)word[i]); // 'A' + 'Z'

                newWord += c;
            }

            return newWord;
        }
    }
}