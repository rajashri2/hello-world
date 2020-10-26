using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/* Don't change anything here.
 * Do not add any other imports. You need to write
 * this program using only these libraries 
 */

namespace ProgramNamespace
{
    /* You may add helper classes here if necessary */

    public class Program
    {
        public static List<String> processData(
                                        IEnumerable<string> lines)
        {
            /* 
             * Do not make any changes outside this method.
             *
             * Modify this method to process `array` as indicated
             * in the question. At the end, return a List containing
             * the appropriate values
             *
             * Do not print anything in this method
             *
             * Submit this entire program (not just this function)
             * as your answer
             */
            List<String> retVal = new List<String>();
            return retVal;
        }

        static void Main(string[] args)
        {
            try
            {
                String line;
                var inputLines = new List<String>();
                while((line = Console.ReadLine()) != null) {
                  line = line.Trim();
                  if (line != "")
                    inputLines.Add(line);
                }
                var retVal = processData(inputLines);
                foreach(var res in retVal)
                  Console.WriteLine(res);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
