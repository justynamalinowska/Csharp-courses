using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Run
    {
        static Func<float, float, float> Plus = (a, b) => a + b;
        static Func<float, float, float> Minus = (a, b) => a - b;
        static Func<float, float, float> Divide = (a, b) => a / b;
        static Func<float, float, float> Multiply = (a, b) => a * b;

        Dictionary<string, Func<float, float, float>> Operators = new Dictionary<string, Func<float, float, float>>
        {
            ["+"] = Plus,
            ["-"] = Minus,
            ["/"] = Divide,
            ["*"] = Multiply
        };


        public static Func<float, float, float> OperationGet(string text)
        {
            switch (text)
            {
                case "+":
                    return Plus;
                    break;

                case "-":
                    return Minus;
                    break;

                case "/":
                    return Divide;
                    break;

                case "*":
                    return Multiply;
                    break;


                default:
                    return null;
                    break;
            }

        }
    }
}