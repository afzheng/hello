#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion
namespace hello.CLR
{
    class SampleClass { }
    class testCLR
    {
        static void Main(String[] args)
        {
            CLRSupportExample<int> myintList1 = new CLRSupportExample<int>();
            CLRSupportExample<int> myintList2 = new CLRSupportExample<int>();
            if (myintList1.Equals(myintList2))
            {
                Console.WriteLine("the are same one");
            }
            else
            {
                Console.WriteLine("the are def one");
            }
            Console.WriteLine(myintList1.count);
            Console.WriteLine(myintList2.count);
            Console.ReadLine();
        }
    }
}
