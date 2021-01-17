using CSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiddleOfLinkedList
{
    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {

            if (head == null || head.next == null)
                return head;

            var left = head;
            var right = head;
            while (right != null)
            {
                right = right.next;
                if (right != null)
                {
                    right = right.next;
                    left = left.next;
                }
            }

            return left;
        }
    }
}
