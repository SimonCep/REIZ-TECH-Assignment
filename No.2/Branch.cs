using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No._2
{
    internal class Branch
    {
        public List<Branch> Branches { get; set; }
        public int Data { get; set; }
        public Branch(int Data = 0)
        {
            Branches = new List<Branch>();
            this.Data = Data;
        }
    }
}
