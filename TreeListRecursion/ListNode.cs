namespace TreeListRecursion
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ListNode
    {
        public ListNode(int data)
        {
            this.Data = data;
            this.Previous = this;
            this.Next = this;
        }

        public int Data { get; set; }

        public ListNode Previous { get; set; }

        public ListNode Next { get; set; }
    }
}
