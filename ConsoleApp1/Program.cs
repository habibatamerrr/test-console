using System.Collections.Generic;

namespace PS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inits;
            inits = Initials("Michael", "Mason", "McMillan");
            Console.WriteLine(inits);

        }
        public static string Initials(string fname, string mname, string lname)
        {
            return (String.Format("{0}{1}{2}", fname.Substring(0, 1),
            mname.Substring(0, 1), lname.Substring(0, 1)));
        }
    }
}