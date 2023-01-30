using System.Collections.Generic;

namespace Tree_depth_calculation
{
    class Branch
    {
        List<Branch> branches;

        public Branch()
        {
            branches = new List<Branch>();
        }

        public void AddBranch(Branch branch)
        {
            branches.Add(branch);
        }
        public void RemoveBranch(Branch branch)
        {
            branches.Remove(branch);
        }
        public List<Branch> GetBranches()
        {
            return branches;
        }
    }
}
