using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSource
{
    public class LinkListCode
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head.next == null)
                return head;

            var thisNode = head;
            while (thisNode != null && thisNode.next != null)
            {
                ListNode next = thisNode.next;
                if (thisNode.val == next.val)
                {
                    thisNode.next = next.next;

                }
                else
                {
                    thisNode = thisNode.next;
                }

            }

            return head;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}
