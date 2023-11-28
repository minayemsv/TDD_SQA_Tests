using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_SQA
{
    public class Calculator
    {
        public Calculator()
        {

        }
        public int addinginteger(int integer1, int integer2)
        {
            int sum = integer1 + integer2;
            return sum;
        }
        public float addingfloat(float float1, float float2)
        {
            float sum = float1 + float2;
            return sum;
        }
        public double addingdouble(double double1, double double2)
        {
            double sum = double1 + double2;
            return sum;
        }


        public int subtractinginteger(int integer1, int integer2)
        {
            int result = integer1 - integer2;
            return result;
        }
        public float subtractingfloat(float float1, float float2)
        {
            float result = float1 - float2;
            return result;
        }
        public double subtractingdouble(double double1, double double2)
        {
            double result = double1 - double2;
            return result;
        }



        public int multiplyinginteger(int integer1, int integer2)
        {
            int result = integer1 * integer2;
            return result;
        }
        public float multiplyingfloat(float float1, float float2)
        {
            float result = float1 * float2;
            return result;
        }
        public double multiplyingdouble(double double1, double double2)
        {
            double result = double1 * double2;
            return result;
        }



        public int divisioninginteger(int integer1, int integer2)
        {
            int result = integer1 / integer2;
            return result;
        }
        public float divisioningfloat(float float1, float float2)
        {
            float result = float1 / float2;
            return result;
        }
        public double divisioningdouble(double double1, double double2)
        {
            double result = double1 / double2;
            return result;
        }
    }
}
