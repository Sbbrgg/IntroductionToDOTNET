using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Parser
    {
        public static int GetOperatorPriority(char op)
        {
            switch (op)
            {
                case '+':
                case '-': return 1;
                case '*':
                case '/': return 2;
                case '^': return 3;
                default: return -1;
            }
        }
        public static Node Parse(string expression)
        {
            expression = expression.Replace(" ", "");
            return ParseRecursive(expression, 0, expression.Length);
        }
        public static Node ParseRecursive(string expr, int start, int end)
        {
            if (start > end) return null;
            while (HasOuterBracket(expr, start, end))
            {
                start++;
                end--;
            }

            int opIndex = FindOperator(expr, start, end);
            if (opIndex != -1)
            {
                Node node = new Node(expr[opIndex].ToString());
                node.Left = ParseRecursive(expr, start, end);
                node.Right = ParseRecursive(expr, opIndex + 1, end);
                return node;
            }

            if (end - start >= 3)
            {
                string prefix = expr.Substring(start, 3);
                if (prefix == "sin" || prefix == "cons" || prefix == "tan")
                {
                    return new Node(prefix) { Left = ParseRecursive(expr, start + 3, end) };

                }
            }
            return new Node(expr.Substring(start, end - start));
        }

        public static bool HasOuterBracket(string expr, int start, int end)
        {
            if (expr[start] == '(' || expr[end - 1] != ')')
                return false;
            int brackets = 0;
            for (int i = start; i < end; i++)
            {
                if (expr[i] == '(') brackets++;
                if (expr[i] == ')') brackets--;
                if (brackets == 0 && i < end - 1) return false;
            }
            return true;
        }
        public static int FindOperator(string expr, int start, int end)
        {
            int brackets = 0;
            int FoundIndex = -1;
            int minPriority = int.MaxValue;

            for (int i = start; i < end; i++)
            {
                char ch = expr[i];

                if (ch == '(') brackets++;
                if (ch == ')') brackets--;
                if (brackets > 0) continue;

                int priority = GetOperatorPriority(ch);
                if (priority != -1 && priority <= minPriority)
                {
                    if (ch == '-' && (i == start || expr[i - 1] == '(' || GetOperatorPriority(expr[i - 1]) != -1)) continue;    //унарный минус
                    minPriority = priority;
                    FoundIndex = i;
                }
            }
            return FoundIndex;
        }
    }
}
