using System;

namespace _28_10_2021h
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ReversSentence("Hello. P202 grup? "));
        }

        static string ReversSentence(string Sentence)
        {
            int Flag = 0;
            string ResultSentence = string.Empty;
            for (int i = 0; i < Sentence.Length; i++)
            {

                if (Sentence[i] == '.' || Sentence[i] == ',' || Sentence[i] == ' ' || Sentence[i] == '?' || Sentence[i] == '!' || Sentence[i] == ':')
                {
                    ResultSentence += ReverseWord(Sentence, i - 1, Flag)+ Sentence[i];
                     // ResultSentence +=Sentence[i];
                    Flag = i + 1;
                }
            }
            return ResultSentence;
        }
        static string ReverseWord(string Word, int i, int Flag)
        {
            string Result = string.Empty;
            while (i >= Flag)
            {
                Result += Word[i];
                i--;
            }
             
            return Result;
        }
    }
}
