using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int depth = 1;
            Branch Structure = new Branch(1);
            CreatingTheGivenStructure(Structure);
            depth = Depth(Structure, depth);
            Console.WriteLine("The depth of the provided structure is: {0}", depth);
            Console.WriteLine("The program has finished it's work.");
        }
        /// <summary>
        /// Method to create the given structure.
        /// </summary>
        /// <param name="Structure"></param>
        public static void CreatingTheGivenStructure(Branch Structure)
        {
            Structure.Branches.Add(new Branch(2));
            Structure.Branches.Add(new Branch(2));

            Structure.Branches[0].Branches.Add(new Branch(3));
            Structure.Branches[1].Branches.Add(new Branch(3));
            Structure.Branches[1].Branches.Add(new Branch(3));
            Structure.Branches[1].Branches.Add(new Branch(3));

            Structure.Branches[0].Branches[0].Branches.Add(new Branch(4));

            Structure.Branches[1].Branches[0].Branches.Add(new Branch(4));
            Structure.Branches[1].Branches[1].Branches.Add(new Branch(4));
            Structure.Branches[1].Branches[1].Branches.Add(new Branch(4));
            Structure.Branches[1].Branches[2].Branches.Add(new Branch(4));

            Structure.Branches[1].Branches[1].Branches[0].Branches.Add(new Branch(5));

        }
        /// <summary>
        /// Recursive method to find the depth of the given structure.
        /// </summary>
        /// <param name="Structure"></param>
        /// <param name="currentDepth"></param>
        /// <returns>The depth of the structure</returns>
        public static int Depth(Branch Structure, int currentDepth)
        {
            if (Structure.Branches.Count == 0)
                return currentDepth;
            int maxDepth = currentDepth;
            for (int i = 0; i < Structure.Branches.Count; i++)
            {
                int result = Depth(Structure.Branches[i], currentDepth + 1);
                if (result > maxDepth)
                    maxDepth = result;
            }
            return maxDepth;
        }
    }
}
