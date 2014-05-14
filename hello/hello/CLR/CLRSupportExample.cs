#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace hello.CLR
{
    public class CLRSupportExample<T>
    {
        private static int objCount = 0;
        public CLRSupportExample()
        {
            objCount++;
        }
        public int count
        {
            get
            { return objCount; }
        }
    }
}
