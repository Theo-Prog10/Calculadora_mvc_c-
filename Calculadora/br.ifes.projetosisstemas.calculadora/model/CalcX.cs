using Model.Operation;

namespace Model
{
    public class CalcX : ICalc
    {
        public int Calculation(IOperation operation, int value1, int value2)
        {
            Console.WriteLine("XXXX");
            return operation.Calc(value1, value2);
        }
    }
}
