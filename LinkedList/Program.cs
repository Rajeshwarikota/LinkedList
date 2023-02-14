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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n1.Add Elements into LinkedList \n2.AddFirst \n3.AddLast \n4.InsertAtAnyPoint \n5.RemoveFirst \n6.Removelast \n7.search \n8.size \n22.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.Display();
                        break;
                    case 2:
                        list.AddFist(70);
                        list.AddFist(30);
                        list.AddFist(56);
                        list.Display();
                        break;
                    case 3:
                        list.Append(56);
                        list.Append(30);
                        list.Append(70);
                        list.Display();
                        break;
                    case 4:
                        list.Append(56);
                        list.Append(70);
                        list.InsertAtAnyPoint(30, 56);
                        list.Display();
                        break;

                    case 5:
                        list.Append(56);
                        list.Append(30);
                        list.Append(70);
                        list.RemoveFirst();
                        list.Display();
                        break;
                    case 6:
                        list.Append(56);
                        list.Append(30);
                        list.Append(70);
                        list.RemoveLast();
                        list.Display();
                        break;
                    case 7:
                        list.Append(56);
                        list.Append(30);
                        list.Append(70);
                        list.Search(70);
                        list.Display();
                        break;
                    case 8:
                        list.Append(56);
                        list.Append(30);
                        list.Append(70);
                        list.Display();
                        list.Size();
                        break;


                    case 22:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Choose the correct number ! ");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
