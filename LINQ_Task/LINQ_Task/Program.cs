using LINQ_Task;
using System;

class Program
{
    static void Main(string[] args)
    {
        string text = @"Historically, the world of data and the world of objects" +
          @" have not been well integrated. Programmers work in C# or Visual Basic" +
          @" and also in SQL or XQuery. On the one side are concepts such as classes," +
          @" objects, fields, inheritance, and .NET APIs. On the other side" +
          @" are tables, columns, rows, nodes, and separate languages for dealing with" +
          @" them. Data types often require translation between the two worlds; there are" +
          @" different standard functions. Because the object world has no notion of query, a" +
          @" query can only be represented as a string without compile-time type checking or" +
          @" IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to" +
          @" objects in memory is often tedious and error-prone.";

        //Console.WriteLine(text);

        string searchTerm = "data";

        // Convert the string into an array of words
        // Split '.', '?', '!', ' ', ';', ':', ','
        string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

        // Create the query.  Use the InvariantCultureIgnoreCase comparison to match "data" and "Data"
        //var matchQuery = source.Where(word => word.Equals(searchTerm, StringComparison.InvariantCultureIgnoreCase));
        var matchQuery = source.Where(word => word.Equals(searchTerm));
        //Console.WriteLine(matchQuery);

        // Count the matches, which executes the query.
        int wordCount = matchQuery.Count();
        var word = Array.FindAll(source,s => s == searchTerm);
        //Console.WriteLine(word);
        //for(int i = 0;i<source.Length;i++)
        //{
        //    if (source[i] == searchTerm)
        //    {
        //        Console.WriteLine($"{i}, ");
        //    }
        //}
        //Console.WriteLine($"{wordCount} occurrences(s) of the search  term '{searchTerm}' were found");

        //foreach (string sourceItem in source)
        //{
        //    Console.WriteLine(sourceItem);
        //}
        //Console.WriteLine();
        //Task2 task = new Task2();
        //task.StringTask();
        //Console.ReadKey();

        //Task3 identifyDifferName = new Task3();
        //identifyDifferName.IdentifyDifferentName();
        //Console.ReadKey();

        Task4 charTask = new Task4();
        charTask.WorkWithChar();
        Console.ReadKey();




    }
}







