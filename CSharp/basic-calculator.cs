using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator
{
    public class Solution
    {

        class Node
        {
            public int Val;
            public char Operator;
            public Node Left;
            public Node Right;
        }

        bool IsOperator(char c)
        {
            return c == '+' || c == '-';
        }

        int FindEndBracket(string s, int start, int end)
        {
            var counter = 1;
            var i = start;
            for (; i <= end && counter > 0; i++)
            {
                if (s[i] == '(')
                    counter++;
                else if (s[i] == ')')
                    counter--;
            }

            return --i;
        }

        int ReadVal(string s, ref int start, int end)
        {

            var val = 0;
            for (; start <= end; start++)
            {
                if (Char.IsDigit(s[start]))
                {
                    val *= 10;
                    val += int.Parse(s[start].ToString());
                }
                else
                {
                    break;
                }
            }
            start--;            
            return val;
        }

        Node CreateTree(string s, int start, int end)
        {
            var root = new Node();
            var curr = root;

            for (var i = start; i <= end; i++)
            {
                if (s[i] == ' ')
                    continue;
                else if (s[i] == '(')
                {
                    var eob = FindEndBracket(s, i + 1, end);
                    if (curr.Operator == 0)
                    {
                        curr = CreateTree(s, i + 1, eob - 1);
                    }
                    else
                    {
                        curr.Right = CreateTree(s, i + 1, eob - 1);
                    }

                    i = eob;
                }
                else if (Char.IsDigit(s[i]))
                {
                    var newVal = ReadVal(s, ref i, end);
                    if (curr.Operator == 0)
                        curr.Val = newVal;
                    else
                        curr.Right = new Node() { Val = newVal };
                }
                else if (IsOperator(s[i]))
                {
                    if (curr.Operator == 0)
                    {
                        curr.Operator = s[i];
                        curr.Left = new Node() { Val = curr.Val };
                    }
                    else
                    {
                        root = new Node() { Operator = s[i], Left = curr };
                        curr = root;
                    }
                }
            }

            return curr;
        }

        int EvalTree(Node root)
        {
            if (root.Operator == 0)
            {                
                return root.Val;
            }
            else
            {
                var left = EvalTree(root.Left);
                var right = EvalTree(root.Right);
                switch (root.Operator)
                {
                    case '+':
                        return left + right;
                    case '-':
                        return left - right;
                    default:
                        return 0;
                }
            }
        }
        public int Calculate(string s)
        {
            var root = CreateTree(s, 0, s.Length - 1);
            return EvalTree(root);
        }
    }
}
