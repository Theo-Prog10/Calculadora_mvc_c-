using Model.Operation;

namespace Model.Operation
{
    public class Somar : IOperation
    {
        public int Calc(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
