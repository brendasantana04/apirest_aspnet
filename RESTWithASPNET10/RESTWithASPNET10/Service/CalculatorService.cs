namespace RESTWithASPNET10.Service
{
    public class CalculatorService
    {
        public decimal Sum(decimal firstNumber, decimal secondNumber) => firstNumber + secondNumber;
        public decimal Subtracao(decimal firstNumber, decimal secondNumber) => firstNumber - secondNumber;
        public decimal Multiplicacao(decimal firstNumber, decimal secondNumber) => firstNumber * secondNumber;
        public decimal Divisao(decimal firstNumber, decimal secondNumber)
        {
            if (secondNumber == 0) throw new DivideByZeroException("Divisão com zero é probibida");
            return firstNumber / secondNumber;
        }
        public decimal Media(decimal firstNumber, decimal secondNumber) => (firstNumber + secondNumber) / 2;
        public double Raiz(decimal number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException("Zero não pode");
            return Math.Sqrt((double) number);
        }
    }
}
