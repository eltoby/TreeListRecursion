using System;
using System.Collections.Generic;

namespace TreeListRecursion
{
    public class Converter
    {
        public ListNode Convert(TreeNode treeNode)
        {
            if (treeNode == null)
                return null;

            ListNode last; 
            var first = ConvertPart(treeNode, null, null, out last);
            last.Next = first;
            first.Previous = last;
            return first;
        }

        private ListNode ConvertPart(TreeNode treeNode, ListNode previous, ListNode next, out ListNode last)
        {            
            var node = new ListNode(treeNode.Data);
            
            ListNode result;
            if (treeNode.Left == null)
            { 
                result = node;
                node.Previous = previous ?? node;
            }
            else
            {
                result = this.ConvertPart(treeNode.Left, previous ?? node, node, out last);
                last.Next = node;
                node.Previous = last;
            }

            if (treeNode.Right == null)
            { 
                node.Next = next ?? result;
                last = node;
            }
            else
            {
                var right = this.ConvertPart(treeNode.Right, node, next ?? node, out last);
                node.Next = right;
            }

            return result;
        }
    }
}
