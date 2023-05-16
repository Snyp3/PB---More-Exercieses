using System;


namespace While_Loop3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string text = string.Empty;
            string exitWord = string.Empty;
            int cCount = 0;
            int nCount = 0;
            int oCount = 0;


            while ((input = Console.ReadLine()) != "End")
            {
                char letter = char.Parse(input);

                
                if ( letter >= 'a'  && letter <= 'z' || (letter >= 'A' && letter <= 'Z'))
                {
                    if (input == "c" && cCount==0)
                    {
                        cCount++;
                    }
                    else if (input == "n" && nCount==0)
                    {
                        nCount++;
                    }
                    else if (input == "o" && oCount == 0) 
                    {
                        oCount++;
                    }
                    else
                    {
                        text += letter;
                    }
                    if (cCount + nCount + oCount == 3) 
                    {
                        exitWord += text;
                        exitWord += ' ';
                        text = string.Empty;
                        cCount = 0;
                        nCount = 0;
                        oCount = 0;

                    }
                }
            }
            Console.WriteLine(exitWord);

        }
    }
}
