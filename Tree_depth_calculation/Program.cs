using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_depth_calculation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static int TreeDepth(Branch root)
        {
            List<Branch> branches =  root.GetBranches();
            int maxDepth = 0;

            // base case
            if (branches.Count == 0)
                return 0;

            // find max depth from current node
            foreach(var branch in branches)
            {
                int depth = TreeDepth(branch);
                
                if (maxDepth < depth)
                    maxDepth = depth;
            }

            // add current node to subtree depth and return
            return maxDepth + 1;
        }
    }
}
