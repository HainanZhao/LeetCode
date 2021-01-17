using CSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveNthFromEnd
{
    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var right = head;
            for (int i = 0; i < n; i++)
            {
                right = right.next;
                if (right == null)
                {
                    if (head.next == null)
                        return null;
                    else
                        return head.next;
                }
            }

            var left = head;
            while (right.next != null)
            {
                left = left.next;
                right = right.next;
            }

            left.next = left.next.next;

            return head;
        }
    }
}
