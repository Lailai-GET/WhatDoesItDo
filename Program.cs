using System.Xml.Schema;

namespace WhatDoesItDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {


                text = Console.ReadLine();
                text = text.ToLower();
                int total = 0;
                foreach (var character in text ?? string.Empty)
                {
                    counts[(int)character]++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        total = total + counts[i];
                    }
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        int characterCount = counts[i];
                        double result = PercentGetter(total, counts[i]);
                        string writeThis = character + " - " + counts[i] + " " + result.ToString("F2") + "%";
                        Console.CursorLeft = Console.BufferWidth - writeThis.Length;
                        Console.WriteLine(writeThis);
                        //Googlet høyreorientering og kom frem til det samme som løsningsforslaget xD
                        //Formatering av desimaltall spurte jeg på teamet som hadde sett løsningsforslaget allerede
                        //lærte masse, da!
                    }
                }
            }
            double PercentGetter(int numTot, int numCount)
            {

                {

                    double result = 0;
                    result = (double)numCount / (double)numTot * 100;
                    return result;
                }
            }

        }
    }
}