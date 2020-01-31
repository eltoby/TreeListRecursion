using System;
using System.Collections.Generic;
using System.Text;

namespace TreeListRecursion
{
    public class TreeNode
    {
        public TreeNode(int data)
        {
            this.Data = data;
        }

        public int Data { get; set; }

        public TreeNode Left { get; set; }

        public TreeNode Right { get; set; }
    }
}
