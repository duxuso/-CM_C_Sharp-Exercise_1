using System;

namespace NullOrEmptyString
{
    /// <summary>
    /// Class 'NullOrEmptyStrings' 
    /// </summary>
    public class NullOrEmptyStrings
    {
        /// <summary>
        /// Finding if a string is null, empty or not, according to
        ///    1. when string str equals to a null
        ///    str == null;
        ///    2. when the length of string str is ZERO 
        ///    str.length == 0;
        /// </summary>
        private bool tof; // create a true or false flag

        // Start a if-else clause 
        public bool isNullOrEmpty(string s) 
        {
            // when string equals to null, returns true
            if (s == null)
            {
                Console.Write("Input string is null, ");
                tof = true;
            }
            // if string is not null, then if its length is 0, returns true  
            else if (s.Length == 0)
            {
                Console.Write("Input string is empty, ");
                tof = true;
            }
            // else if string is not a null and its length is not 0, returns false.
            else
            {
                Console.Write("Input string is not null or empty, ");
                tof = false;
            }
            // return a true/ false 
            return tof;
        }

        /// <summary>
        /// Call method 'isNullOrEmpty' in Main() 
        /// </summary>
        public static void Main(){
            // Prepare string arguments, to be tested in 'isNullOrEmpty' later 
            string s1 = null;
            string s2 = "a";
            string s3 = "";
            string s4 = "null";

            // class instantiation, perpare to call method 'isNullOrEmpty'
            NullOrEmptyStrings noes = new NullOrEmptyStrings();

            // sample 1, when passing in a null
            bool b1 = noes.isNullOrEmpty(s1);
            Console.WriteLine("Sample input: \"{0}\", output: {1}", s1, b1);
            Console.ReadLine();

            // sample 2, when passing in string 'a' 
            bool b2 = noes.isNullOrEmpty(s2);
            Console.WriteLine("Sample input: \"{0}\", output: {1}", s2, b2);
            Console.ReadLine();

            // sample 3, when passing in an empty string
            bool b3 = noes.isNullOrEmpty(s3);
            Console.WriteLine("Sample input: \"{0}\", output: {1}", s3, b3);
            Console.ReadLine();

            // sample 4, when passing in string 'null'
            bool b4 = noes.isNullOrEmpty(s4);
            Console.WriteLine("Sample input: \"{0}\", output: {1}", s4, b4);
            Console.ReadLine();
        }
    }
}
