using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Task
{
    internal class Task3
    {
        public void IdentifyDifferentName()
        {
            string filePath1 = @"D:\C#\sampleFile\NameList1.txt";
            string filePath2 = @"D:\C#\sampleFile\NameList2.txt";
            try
            {
                string[] names1 = File.ReadAllLines(filePath1); // some names, you can populate from .txt file
                string[] names2 = File.ReadAllLines(filePath2);// some names, you can populate from .txt file

                Console.WriteLine("name1");
                foreach(var name in names1) Console.WriteLine(name);
                Console.WriteLine("name2");
                foreach (var name in names2) Console.WriteLine(name);
                // Create the query. Note that method syntax must be used here.  
                IEnumerable<string> differenceQuery = from a in names2.Union(names1).ToList()
                                                      select a;// to do

                // Execute the query.  
                Console.WriteLine("The following names are in names1 but not names2");
                foreach (string s in differenceQuery)
                    Console.WriteLine(s);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           

        }

    }
}
