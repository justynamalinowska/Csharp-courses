using System;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Coding.Exercise
{
    class Run
    {

        public delegate float OperationDelegate(float a, float b);


        public static float Add(float a, float b)
        {
            return a + b;
        }
        public static float Substract(float a, float b)
        {
            return a - b;
        }
        public static float Multiply(float a, float b)
        {
            return a * b;
        }
        public static float Divide(float a, float b)
        {
            return a / b;
        }

        static float ApplyOperation(float a, float b, OperationDelegate operation)
        {
            float result;
            result = operation(a, b);
            return result;
        }
    }
}