namespace Task2
{
    interface ICalculator
    {
        double Sum(double a, double b); // '+'

        double Subtraction(double a, double b); // '-'

        double Multiplication(double a, double b); // '*'

        double Division(double a, double b); // '/'

        void DisplayResult(double result); // '='

        double ReadNumber();
    }
}
