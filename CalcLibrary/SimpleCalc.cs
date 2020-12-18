using System;

namespace CalcLibrary
{
    public class SimpleCalc
    {
        public decimal add(decimal value1, decimal value2)
        {
            return value1 + value2;
        }
        public decimal subtract(decimal value1, decimal value2)
        {
            return value1 - value2;
        }
        public decimal multiply(decimal value1, decimal value2)
        {
            return value1 * value2;
        }
        public decimal divide(decimal value1, decimal value2)
        {
            if (value2 == 0)
            {
                return value2;
            }
            else
            {
                return value1 / value2;
            }
        }

        public decimal OperatorSwitch(decimal value1, decimal value2, string operate)
        {
            decimal result;
            switch (operate)
            {
                case "add":
                    result = value1 + value2;
                    break;
                case "subtract":
                    result = value1 - value2;
                    break;
                case "multiply":
                    result = value1 * value2;
                    break;
                case "divide":
                    if (value2 == 0)
                    {
                        result = value2;
                    }
                    else
                    {
                        result = value1 / value2;
                    }
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }
    }
}