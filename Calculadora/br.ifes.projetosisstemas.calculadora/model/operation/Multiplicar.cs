using Model.Operation;

namespace Model.Operation{
    public class Multiplicar : IOperation{
        public int Calc(int valor1, int valor2){
            return valor1 * valor2;
        }
    }
}