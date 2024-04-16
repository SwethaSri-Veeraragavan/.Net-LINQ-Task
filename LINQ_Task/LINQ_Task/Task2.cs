using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Task
{
    internal class Task2
    {
        public void StringTask()
        {
            string text1 = @"Historically, the world of data and the world of objects" +
         @" have not been well integrated. Programmers work in C# or Visual Basic" +
         @" and also in SQL or XQuery. On the one side are concepts such as classes," +
         @" objects, fields, inheritance, and .NET APIs. On the other side" +
         @" are tables, columns, rows, nodes, and separate languages for dealing with" +
         @" them. Data types often require translation between the two worlds; there are" +
         @" different standard functions. Because the object world has no notion of query, a" +
         @" query can only be represented as a string without compile-time type checking or" +
         @" IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to" +
         @" objects in memory is often tedious and error-prone.";

            // Split the text block into an array of sentences.
            string[] sentences = text1.Split(".");// to do

            // Define the search terms.
            string[] wordsToMatch = { "Historically", "data", "integrated"};

            // Find sentences that contain all the terms in the wordsToMatch array.
            var sentenceQuery = sentences.Where(s => wordsToMatch.All(words => s.Contains(words)));// to do

            //Console.WriteLine(sentenceQuery);
            foreach (string str in sentenceQuery)
            {
                Console.WriteLine(str);
            }
        }
       
    }
}
