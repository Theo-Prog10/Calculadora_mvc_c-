using Model.Operation;

namespace Model{
    public interface ICalc{
        int Calculation(IOperation operation, int value1, int value2);
    }
}
