using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree(8);
            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(6);
            tree.Insert(11);

            var found = tree.Find(2);

            Console.WriteLine(found.Value);
            Console.ReadLine();
        }
    }
}