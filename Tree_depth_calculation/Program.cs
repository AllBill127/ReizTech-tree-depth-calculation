using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Tree_depth_calculation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Branch root = new Branch();

            // populate tree
            TreeStructureManipulation.PopulateTree(root, 0);
            // Calculate and print tree depth
            Console.WriteLine("\nRandom tree depth is = " + TreeStructureManipulation.TreeDepth(root));
            Console.WriteLine("\nExample tree depth is = " + TreeStructureManipulation.TreeDepth(TreeStructureManipulation.ExampleTree()));
            return;
        }
    }
}
