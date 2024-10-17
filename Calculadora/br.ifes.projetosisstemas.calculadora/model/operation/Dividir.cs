using System;

namespace Model.Operation
{
    public class Dividir : IOperation{
        public int Calc(int value1, int value2){
            if (value2 == 0)
                throw new ArithmeticException("Divisão por zero não permitida");

            return value1 / value2;
        }
    }
}
