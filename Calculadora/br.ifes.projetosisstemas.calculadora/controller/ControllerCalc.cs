
using DTO;
using Model;
using Model.Operation;

namespace Controller
{
    public class ControllerCalc
    {
        public ResponseDTO Calc(RequestDTO requestDTO)
        {
            int result = 0;
            ICalc calc;

            if (requestDTO.Opcao == "Somar")
            {
                calc = new Calc();
            }
            else
            {
                calc = new CalcX();
            }

            // Localiza e instancia a classe da operação dinamicamente
            string operationClassName = $"Model.Operation.{requestDTO.Opcao}";
            Type operationClass = Type.GetType(operationClassName);
            
            if (operationClass == null)
            {
                throw new Exception($"Operação {requestDTO.Opcao} não encontrada.");
            }

            // Instancia a operação dinamicamente
            IOperation operation = (IOperation)Activator.CreateInstance(operationClass);

            // Realiza o cálculo
            result = calc.Calculation(operation, requestDTO.Valor1, requestDTO.Valor2);

            return new ResponseDTO(result);
        }
    }
}
