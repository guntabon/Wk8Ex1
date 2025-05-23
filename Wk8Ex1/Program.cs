﻿using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk8Ex1
{
    class Program
    {

        
        static void Main(string[] args)
        {
            //This line sets the file path and stores it to "filePath" so we can use that variable instead of the full path every time we use it in the future
            string filePath = "C:\\Users\\gunne\\OneDrive\\Desktop\\Vscode\\Wk8\\myFIle.txt";

            //This sets an int "wordCount" and calls the CountWords function, using filePath, (or "C:\Users\gunne\OneDrive\Desktop\Vscode\Wk8\myFIle.txt") as a reference
            int wordCount = CountWords(filePath);

            //This line indicates how many words are in the text document, and uses "wordCount" with $ {} to call it easier in the line
            Console.WriteLine($"This file contains {wordCount} words: ");

            //This keeps the console up for use after runnnign
            Console.Read();
        }

        //This creates an int based function CountWords, using the string filePath to reference for the function
        static int CountWords(string filePath)
        {
            //This sets "content" as the full value of the text document to use later
            string content = File.ReadAllText(filePath);

            //creates array words and splits content using spaces/line breaks
            string[] words = content.Split(new char[] { ' ', '\n', '\r', '\t' });

            //returns the length of the character counted in the text file
            return words.Length;
        }
    }
}
