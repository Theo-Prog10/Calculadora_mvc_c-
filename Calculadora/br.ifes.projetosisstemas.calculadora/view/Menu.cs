using System;
using DTO;

namespace View{
    public class Menu{
        public RequestDTO Show(){
            ShowMenu();
            return CaptureValues();
        }

        private RequestDTO CaptureValues(){
            Console.WriteLine("Informe a operação desejada:");
            string opcao = Console.ReadLine();

            Console.WriteLine("Informe o primeiro valor:");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor:");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            return new RequestDTO(opcao, valor1, valor2);
        }

        private void ShowMenu(){
            Console.WriteLine("-->Olá Meu fi!<----");
            Console.WriteLine("Informe a operação desejada:");
            Console.WriteLine("Somar");
            Console.WriteLine("Subtrair");
            Console.WriteLine("Multiplicar");
            Console.WriteLine("Dividir");
        }

        public void ShowResult(ResponseDTO responseDTO){
            Console.WriteLine("O Resultado é: " + responseDTO.Result);
        }
    }
}
