using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Calculate
    {
        public double CAlculate(string exp)
        {
            Node node = Parser. Parse(exp);
            return Evaluate(node);
        }
        public double Evaluate(Node node)
        {
            if (node == null) return 0;

            if (node.Value == "sin" || node.Value == "cos" || node.Value == "tan")
            {
                double arg = Evaluate(node.Left);
                switch (node.Value)
                {
                    case "sin": return Math.Sin(arg);
                    case "cos": return Math.Cos(arg);
                    case "tan": return Math.Tan(arg);
                    default: return 0;
                }
            }
            double leftValue = Evaluate(node.Left);
            double rightValue = Evaluate(node.Right);
            switch (node.Value)
            {
                case "+": return leftValue + rightValue;
                case "-": return leftValue - rightValue;
                case "*": return leftValue * rightValue;
                case "/": return rightValue != 0 ? leftValue/rightValue : int.MaxValue;
                case "^": return Math.Pow(leftValue, rightValue);
                default: return 0;
            }
        }
    }
}
