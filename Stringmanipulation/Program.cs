using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Stringmanipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter string!");
            string userString = Console.ReadLine();
            //Replaces all spaces with underscore
            string spcTo_ = userString.Replace(" ", "_");
            Console.WriteLine("1. Replaces all spaces with underscore\n" + spcTo_);
            //Removes leading spaces
            string leadingSpc = userString.TrimStart();
            Console.WriteLine("2. Removes leading spaces\n" + leadingSpc);
            //Removes trailing space
            //string trailingSpc = userString.Trim();
            string trailingSpc = Regex.Replace(leadingSpc, @"\s+", " ");
            Console.WriteLine("3. Removes trailing space\n" + trailingSpc);
            //Replaces all lowercase A by uppercase A
            string AToUppar = userString.Replace("a", "A");
            Console.WriteLine("4. Replaces all lowercase A by uppercase A\n" + AToUppar);
            // make the string letters all upparcase
            string upperCase = userString.ToUpper();
            Console.WriteLine("5. make the string letters all upparcase\n" + upperCase);

            Console.Read();

        }
    }
}
