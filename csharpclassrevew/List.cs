using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpclassrevew
{
    internal class List
    {
        public void list()
        {
            

             
            var name = new List<string>(); // Create a list of strings 
            name.Add("suraj");
            name.Add("kumar");
            name.Add("dev");
            
             
            foreach (var Name in name)    // print list element using foreach loop
            {
                Console.WriteLine(Name);
            }





        }
    }
}
