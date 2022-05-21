using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpclassrevew
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PerfectNumber perfectNumber = new PerfectNumber();
            perfectNumber.Perfect();

            ReverseNumber reverseNumber = new ReverseNumber();
            reverseNumber.Reverse();

            genericseg genericseg = new genericseg();
            genericseg.generic();

            List list = new List();
            list.list();
        }
    }
}
