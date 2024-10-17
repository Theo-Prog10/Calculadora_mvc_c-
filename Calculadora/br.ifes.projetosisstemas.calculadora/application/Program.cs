
using Controller;
using DTO;
using View;

namespace Application{
    class Program{
        public static void Main(string[] args){
            Menu menu = new Menu();
            RequestDTO requestDTO = menu.Show();
            ControllerCalc controllerCalc = new ControllerCalc();
            ResponseDTO responseDTO = controllerCalc.Calc(requestDTO);
            menu.ShowResult(responseDTO);
            
        }
    }
}
