using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Task
{
    internal class Task4
    {
        public void WorkWithChar()
        {
            string aString = "ABCDE99F-J74-12-89A";

            // Select only those characters that are numbers(regex)
            IEnumerable<char> stringQuery = aString.Where(a => char.IsDigit(a));

            // Execute the query  
            foreach (char c in stringQuery)
                Console.Write(c + " ");

            // Call the Count method on the existing query.  
            int count = stringQuery.Count();
            Console.WriteLine("\nCount = {0}", count);

            // Select all characters before the first '-'  (split,regex
            IEnumerable<char> stringQuery2 = aString.TakeWhile(a => a != '-'); // to do

            // Execute the second query  
            foreach (char c in stringQuery2)
                Console.Write(c);

        }
    }
}
