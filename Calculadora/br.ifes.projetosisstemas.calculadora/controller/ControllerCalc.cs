
using DTO;
using Model;
using Model.Operation;

namespace Controller{
    public class ControllerCalc{
        public ResponseDTO Calc(RequestDTO requestDTO){
            int result = 0;
            ICalc calc;

            if (requestDTO.Opcao == "Somar"){
                calc = new Calc();
            }
            else{
                calc = new CalcX();
            }

            //pega o nome da classe e instancia a classe da operação
            string operationClassName = $"Model.Operation.{requestDTO.Opcao}";
            Type operationClass = Type.GetType(operationClassName);

            //Instancia a operação
            IOperation operation = (IOperation)Activator.CreateInstance(operationClass);

            result = calc.Calculation(operation, requestDTO.Valor1, requestDTO.Valor2);

            return new ResponseDTO(result);
        }
    }
}
