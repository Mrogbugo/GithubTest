using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unboxValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int three = 3;
            int threeagain = 3;

            bool intCmp = (three == threeagain);
            Console.WriteLine(string.Format("Compare ints: {0}", intCmp));

            /* this code will evalualte two integer store three and threeagain to know  
             * if there are equal which will print true on the cmd*/

            bool Cmpobj = ((object)three == (object)threeagain);
            Console.WriteLine(string.Format("Compare object: {0}", Cmpobj));
            /* this code will return False because both variable have been cast to object 
             * which is reference type  
             * casting valutype to object boxes them then == does reference type*/

            bool itfcmp = ((IComparable<int>)three == (IComparable < int > )threeagain);
            Console.WriteLine(string.Format("compare interface: {0}", itfcmp));
            
           /* this cast both integer to icomparable int, in dot net interface referrance is always 
            referrance type so this involes boxing too*/  

            ghggj

        }
    }
}
