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
        public int addinteger(int integer1, int integer2)
        {
            int sum = integer1 + integer2;
            return sum;
        }
        public float addfloat(float float1, float float2)
        {
            float sum = float1 + float2;
            return sum;
        }
        public double adddouble(double double1, double double2)
        {
            double sum = double1 + double2;
            return sum;
        }


        public int subtractinteger(int integer1, int integer2)
        {
            int result = integer1 - integer2;
            return result;
        }
        public float subtractfloat(float float1, float float2)
        {
            float result = float1 - float2;
            return result;
        }
        public double subtractdouble(double double1, double double2)
        {
            double result = double1 - double2;
            return result;
        }



        public int multiplyinteger(int integer1, int integer2)
        {
            int result = integer1 * integer2;
            return result;
        }
        public float multiplyfloat(float float1, float float2)
        {
            float result = float1 * float2;
            return result;
        }
        public double multiplydouble(double double1, double double2)
        {
            double result = double1 * double2;
            return result;
        }



        public int divisioninteger(int integer1, int integer2)
        {
            int result = integer1 / integer2;
            return result;
        }
        public float divisionfloat(float float1, float float2)
        {
            float result = float1 / float2;
            return result;
        }
        public double divisiondouble(double double1, double double2)
        {
            double result = double1 / double2;
            return result;
        }
    }
}
