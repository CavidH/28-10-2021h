using System;

namespace _28_10_2021h
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ReversSentence("salam dunya."));
        }

        static string ReversSentence(string s)
        {
            int Flag = 0;
            string ResultSentence = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] == '.' || s[i] == ',' || s[i] == ' ' || s[i] == '?' || s[i] == '!' || s[i] == ':')
                {
                    ResultSentence += ReverseWord(s, i - 1, Flag);
                    ResultSentence += s[i];
                    Flag = i + 1;
                }
            }
            return ResultSentence;
        }
        static string ReverseWord(string s, int i, int Flag)
        {
            string Result = string.Empty;
            while (i >= Flag)
            {
                Result += s[i];
                i--;
            }
            /**
             * 
            for (; i >= Flag; i--)
            {
                Result += s[i];
            }
            
         **/
            return Result;
        }
    }
}
