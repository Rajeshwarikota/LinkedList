﻿using System;
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
            //list.Add(70);
            //list.Add(30);
            //list.Add(56);

            list.Append(56);
            list.Append(70);
            list.InsertAtAnyPoint(30,56);

            list.Display();
            Console.ReadLine();
        }
    }
}
