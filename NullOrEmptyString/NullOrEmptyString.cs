using System;

namespace NullOrEmptyString
{
    public class NullOrEmptyStrings
    {
        /// <summary>
        /// find a string is null, empty or not
        /// </summary>
        private bool tof;

        // Use if-else clause 
        public bool isNullOrEmpty(string s) 
        {
            if (s == null)
            {
                Console.Write("Input string is null, ");
                tof = true;
            }
            else if (s.Length == 0)
            {
                Console.Write("Input string is empty, ");
                tof = true;
            }
            else
            {
                Console.Write("Input string is not null or empty, ");
                tof = false;
            }
            return tof;
        }

        public static void Main()
        {
            // Prepare test inputs 
            string s1 = null;
            string s2 = "a";
            string s3 = "";
            string s4 = "null";

            // create class instance
            NullOrEmptyStrings noes = new NullOrEmptyStrings();

            bool b1 = noes.isNullOrEmpty(s1);
            Console.WriteLine("Sample input: \"{0}\", output: {1}", s1, b1);
            Console.ReadLine();

            bool b2 = noes.isNullOrEmpty(s2);
            Console.WriteLine("Sample input: \"{0}\", output: {1}", s2, b2);
            Console.ReadLine();

            bool b3 = noes.isNullOrEmpty(s3);
            Console.WriteLine("Sample input: \"{0}\", output: {1}", s3, b3);
            Console.ReadLine();

            bool b4 = noes.isNullOrEmpty(s4);
            Console.WriteLine("Sample input: \"{0}\", output: {1}", s4, b4);
            Console.ReadLine();
        }
    }
}
