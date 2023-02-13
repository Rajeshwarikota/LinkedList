using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....LinkedList....");
            LinkedListCls list = new LinkedListCls();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.ReadLine();
        }
    }
}
