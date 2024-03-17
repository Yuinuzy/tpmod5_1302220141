using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod5_1302220141
{

    internal class halogeneric<T>
    {
        private T data;
        public halogeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Hello " +  data);
        }
    }
}
